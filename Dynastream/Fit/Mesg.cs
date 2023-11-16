#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.126.0Release
// Tag = production/release/21.126.0-0-g0576dfe
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Dynastream.Utility;

namespace Dynastream.Fit
{
    /// <summary>
    ///
    /// </summary>
    public class Mesg
    {
        #region Fields
        protected byte localNum = 0;
        protected uint systemTimeOffset = 0;
        private List<Field> fields = new List<Field>();
        private readonly Dictionary<DeveloperDataKey, DeveloperField> developerFields
            = new Dictionary<DeveloperDataKey, DeveloperField>();
        #endregion

        #region Properties
        public string Name { get; set; }
        public ushort Num { get; set; }
        public byte LocalNum
        {
            get
            {
                return localNum;
            }
            set
            {
                if (value > Fit.LocalMesgNumMask)
                {
                    throw new FitException("Mesg:LocalNum - Invalid Local message number " + value + ". Local message number must be < " + Fit.LocalMesgNumMask);
                }
                else
                {
                    localNum = value;
                }
            }
        }

        public IEnumerable<Field> Fields
        {
            get { return fields; }
        }

        internal IList<Field> FieldsList
        {
            get { return fields; }
        }

        public IEnumerable<DeveloperField> DeveloperFields
        {
            get { return developerFields.Values; }
        }
        #endregion

        #region Constructors
        public Mesg(Mesg mesg)
        {
            if (mesg == null)
            {
                this.Name = "unknown";
                this.Num = (ushort)MesgNum.Invalid;
                return;
            }
            this.Name = mesg.Name;
            this.Num = mesg.Num;
            this.LocalNum = mesg.LocalNum;
            this.systemTimeOffset = mesg.systemTimeOffset;
            foreach (Field field in mesg.FieldsList)
            {
                if (field.GetNumValues() > 0)
                {
                    this.FieldsList.Add(new Field(field));
                }
            }

            foreach (var fld in mesg.DeveloperFields)
            {
                if (fld.GetNumValues() > 0)
                {
                    var key = new DeveloperDataKey(fld.DeveloperDataIndex, fld.Num);
                    developerFields[key] = new DeveloperField(fld);
                }
            }
        }

        public Mesg(string name, ushort num)
        {
            this.Name = name;
            this.Num = num;
        }

        internal Mesg(ushort mesgNum)
            : this(Profile.GetMesg(mesgNum))
        {
        }

        public Mesg(Stream fitStream, MesgDefinition defnMesg)
            : this(defnMesg.GlobalMesgNum)
        {
            Read(fitStream, defnMesg);
        }
        #endregion

        #region Methods
        public void Read(Stream inStream, MesgDefinition defnMesg)
        {
            inStream.Position = 1;
            EndianBinaryReader mesgReader = new EndianBinaryReader(inStream, defnMesg.IsBigEndian);

            LocalNum = defnMesg.LocalMesgNum;

            foreach (FieldDefinition fieldDef in defnMesg.GetFields())
            {
                bool read = true;

                // It's possible the field type found in the field definition may
                // not agree with the type defined in the profile.  The profile
                // type will be preferred for decode.
                Field field = GetField(fieldDef.Num);
                if (field == null)
                {
                    // We normally won't have fields attached to our skeleton message,
                    // as we add values we need to add the fields too based on the mesg,field
                    // combo in the profile.  Must derive from the profile so the scale etc
                    // is correct
                    field = new Field(Profile.GetMesg(this.Num).GetField(fieldDef.Num));
                    if (field.Num == Fit.FieldNumInvalid)
                    {
                        // If there was no info in the profile the FieldNum will get set to invalid
                        // so preserve the unknown fields info while we know it
                        field.Num = fieldDef.Num;
                        field.SetType(fieldDef.Type);
                    }
                    SetField(field);
                }

                if (field.Type != fieldDef.Type)
                {
                    int fieldSize = Fit.BaseType[field.Type & Fit.BaseTypeNumMask].size;
                    int defSize = Fit.BaseType[fieldDef.Type & Fit.BaseTypeNumMask].size;

                    if (defSize < fieldSize)
                    {
                        field.SetType(fieldDef.Type);
                    }
                    else if(defSize != fieldSize)
                    {
                        // Demotion is hard. Don't read the field if the
                        // sizes are different. Use the profile type if the
                        // signedness of the field has changed.
                        read = false;
                    }
                }

                if (read)
                {
                    ReadFieldValue(field, fieldDef.Size, mesgReader);
                }
                else
                {
                    // Skip the bytes for the field if we aren't going to bother reading them
                    mesgReader.ReadBytes(fieldDef.Size);
                }
            }

            foreach (DeveloperFieldDefinition fldDef in defnMesg.DeveloperFieldDefinitions)
            {
                DeveloperField fld = GetDeveloperField(fldDef.FieldNum, fldDef.DeveloperDataIndex);
                if (ReferenceEquals(fld, null))
                {
                    fld = new DeveloperField(fldDef);
                    SetDeveloperField(fld);
                }

                ReadFieldValue(fld, fldDef.Size, mesgReader);
            }
        }

        private static void ReadFieldValue(
            FieldBase field,
            byte size,
            EndianBinaryReader mesgReader)
        {
            byte baseType = (byte)(field.Type & Fit.BaseTypeNumMask);
            // strings may be an array and are of variable length
            if (baseType == Fit.String)
            {
                byte[] bytes = mesgReader.ReadBytes(size);
                List<byte> utf8Bytes = new List<byte>();

                if (!Array.Exists(bytes, x => x != 0))
                {
                    // Array has no non zero values, don't add any strings
                    return;
                }

                for (int i = 0; i < size; i++)
                {
                    byte b = bytes[i];
                    utf8Bytes.Add(b);

                    if (b == 0x00)
                    {
                        field.AddValue(utf8Bytes.ToArray());
                        utf8Bytes.Clear();
                    }
                }

                if (utf8Bytes.Count != 0)
                {
                    // Add a Null Terminator
                    utf8Bytes.Add(0);
                    field.AddValue(utf8Bytes.ToArray());
                    utf8Bytes.Clear();
                }
            }
            else
            {
                int numElements = size / Fit.BaseType[baseType].size;
                for (int i = 0; i < numElements; i++)
                {
                    object value;
                    bool invalid = TryReadValue(
                        out value,
                        field.Type,
                        mesgReader,
                        size);

                    if (!invalid || numElements > 1)
                    {
                        field.SetRawValue(i, value);
                    }
                }
            }
        }

        private static bool TryReadValue(
            out object value,
            byte type,
            EndianBinaryReader mesgReader,
            byte size)
        {
            bool invalid = true;
            byte baseTypeNum = (byte)(type & Fit.BaseTypeNumMask);
            switch (baseTypeNum)
            {
                case Fit.Enum:
                case Fit.Byte:
                case Fit.UInt8:
                case Fit.UInt8z:
                    value = mesgReader.ReadByte();
                    if ((byte) value != (byte) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.SInt8:
                    value = mesgReader.ReadSByte();
                    if ((sbyte) value != (sbyte) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.SInt16:
                    value = mesgReader.ReadInt16();
                    if ((short) value != (short) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.UInt16:
                case Fit.UInt16z:
                    value = mesgReader.ReadUInt16();
                    if ((ushort) value !=
                        (ushort) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.SInt32:
                    value = mesgReader.ReadInt32();
                    if ((int) value != (int) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.UInt32:
                case Fit.UInt32z:
                    value = mesgReader.ReadUInt32();
                    if ((uint) value != (uint) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.SInt64:
                    value = mesgReader.ReadInt64();
                    if ((long) value != (long) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.UInt64:
                case Fit.UInt64z:
                    value = mesgReader.ReadUInt64();
                    if ((ulong) value != (ulong) Fit.BaseType[baseTypeNum].invalidValue)
                    {
                        invalid = false;
                    }
                    break;

                case Fit.Float32:
                    value = mesgReader.ReadSingle();
                    if (!float.IsNaN((float)value))
                    {
                        invalid = false;
                    }
                    break;

                case Fit.Float64:
                    value = mesgReader.ReadDouble();
                    if (!double.IsNaN((double)value))
                    {
                        invalid = false;
                    }
                    break;

                default:
                    value = mesgReader.ReadBytes(size);
                    break;
            }

            return invalid;
        }

        public void Write(Stream outStream)
        {
            Write(outStream, null);
        }

        public void Write(Stream outStream, MesgDefinition mesgDef)
        {
            if (mesgDef == null)
            {
                mesgDef = new MesgDefinition(this);
            }

            EndianBinaryWriter bw = new EndianBinaryWriter(outStream, mesgDef.IsBigEndian);
            bw.Write(LocalNum);

            foreach (FieldDefinition fieldDef in mesgDef.GetFields())
            {
                Field field = GetField(fieldDef.Num);
                if (null == field)
                {
                    field = Profile.GetField(this.Num, fieldDef.Num);
                    if( null != field )
                    {
                        FieldsList.Add(field);
                    }
                    else
                    {
                        field = new Field(fieldDef.Num, fieldDef.Type);
                    }
                }

                WriteField(field, fieldDef.Size, bw);
            }

            foreach (DeveloperFieldDefinition fieldDef in mesgDef.DeveloperFieldDefinitions)
            {
                DeveloperField field = GetDeveloperField(fieldDef.FieldNum, fieldDef.DeveloperDataIndex);

                if (field == null)
                {
                    field = new DeveloperField(fieldDef);
                    SetDeveloperField(field);
                }

                WriteField(field, fieldDef.Size, bw);
            }
        }

        private static void WriteField(FieldBase field, byte size, BinaryWriter bw)
        {
            byte baseType = (byte)(field.Type & Fit.BaseTypeNumMask);

            // The field could be blank, correctly formed or partially filled
            while (field.GetSize() < size)
            {
                if (baseType == Fit.String)
                {
                    // Figure out how much we have to pad
                    byte padAmount = (byte)(size - field.GetSize());
                    //Has to be a string.
                    try
                    {
                        // Get the Last Value of the field
                        byte[] value = (byte[]) field.GetValue( field.GetNumValues() - 1 );
                        List<byte> temp = new List<byte>();

                        if (value != null)
                        {
                            temp.AddRange(value);
                        }

                        for(byte i = 0; i < padAmount; i++)
                        {
                            temp.Add(
                                Convert.ToByte(
                                    Fit.BaseType[baseType].invalidValue));
                        }

                        field.SetValue(temp.ToArray());
                    }
                    catch (Exception)
                    {
                        throw new FitException(
                            "Exception occurred while resizing field to match definition.");
                    }
                }
                else
                {
                    field.AddValue(Fit.BaseType[baseType].invalidValue);
                }
            }

            for (int i = 0; i < field.GetNumValues(); i++)
            {
                object value = field.GetRawValue(i);
                if (value == null)
                {
                    value = Fit.BaseType[baseType].invalidValue;
                }

                switch (baseType)
                {
                    case Fit.Enum:
                    case Fit.Byte:
                    case Fit.UInt8:
                    case Fit.UInt8z:
                        bw.Write((byte) value);
                        break;

                    case Fit.SInt8:
                        bw.Write((sbyte) value);
                        break;

                    case Fit.SInt16:
                        bw.Write((short) value);
                        break;

                    case Fit.UInt16:
                    case Fit.UInt16z:
                        bw.Write((ushort) value);
                        break;

                    case Fit.SInt32:
                        bw.Write((int) value);
                        break;

                    case Fit.UInt32:
                    case Fit.UInt32z:
                        bw.Write((uint) value);
                        break;

                    case Fit.SInt64:
                        bw.Write((long) value);
                        break;

                    case Fit.UInt64:
                    case Fit.UInt64z:
                        bw.Write((ulong) value);
                        break;

                    case Fit.Float32:
                        bw.Write((float) value);
                        break;

                    case Fit.Float64:
                        bw.Write((double) value);
                        break;

                    case Fit.String:
                        bw.Write((byte[]) value);
                        break;

                    default:
                        break;
                }
            }
        }

        #region FieldList Manipulation Functions
        public bool HasField(byte fieldNum)
        {
            foreach (Field field in FieldsList)
            {
                if (field.Num == fieldNum)
                {
                    return true;
                }
            }
            return false;
        }

        public void SetDeveloperField(DeveloperField field)
        {
            var devKey = new DeveloperDataKey(field.DeveloperDataIndex, field.Num);
            developerFields[devKey] = field;
        }

        /// <summary>
        /// Replace an existing field, otherwise add a reference to fields list
        /// </summary>
        /// <param name="field">Caller allocated field</param>
        public void SetField(Field field)
        {
            for (int i = 0; i < FieldsList.Count; i++)
            {
                if (FieldsList[i].Num == field.Num)
                {
                    FieldsList[i] = field;
                    return;
                }
            }
            FieldsList.Add(field);
        }

        /// <summary>
        /// Insert a field at the desired index.  If the field already exists in the mesg it is first removed.
        /// </summary>
        /// <param name="index">Index to insert the field, if index is out of range, the field is added to the end of the list</param>
        /// <param name="field">Caller allocated field</param>
        public void InsertField(int index, Field field)
        {
            // if message already contains this field, remove it
            for (int i = 0; i < FieldsList.Count; i++)
            {
                if (FieldsList[i].Num == field.Num)
                {
                    FieldsList.RemoveAt(i);
                }
            }
            // if the index is out of range, add to the end
            if (index < 0 || index > FieldsList.Count)
            {
                FieldsList.Add(field);
            }
            // insert the new field at desired index
            else
            {
                FieldsList.Insert(index, field);
            }
        }

        public void SetFields(Mesg mesg)
        {
            if (mesg.Num != Num)
            {
                return;
            }
            foreach (Field field in mesg.FieldsList)
            {
                SetField(new Field(field));
            }
        }

        public int GetNumFields()
        {
            return FieldsList.Count;
        }

        private DeveloperField GetDeveloperField(byte fieldNum, byte developerIndex)
        {
            var devKey = new DeveloperDataKey(developerIndex, fieldNum);
            return developerFields.ContainsKey(devKey) ? developerFields[devKey] : null;
        }

        public IEnumerable<FieldBase> GetOverrideField(byte fieldNum)
        {
            LinkedList<FieldBase> localFields = new LinkedList<FieldBase>();

            Field nativeField = GetField(fieldNum);
            if (null != nativeField)
            {
                localFields.AddLast(nativeField);
            }

            foreach(DeveloperField field in DeveloperFields.Where(x => x.NativeOverride == fieldNum))
            {
                localFields.AddLast(field);
            }

            return localFields;
        }

        public Field GetField(byte fieldNum)
        {
            foreach (Field field in FieldsList)
            {
                if (field.Num == fieldNum)
                {
                    return field;
                }
            }

            return null;
        }

        public Field GetField(string fieldName)
        {
            return GetField(fieldName, true);
        }

        public Field GetField(string fieldName, bool checkMesgSupportForSubFields)
        {
            foreach (Field field in FieldsList)
            {
                if (field.Name == fieldName)
                {
                    return field;
                }

                foreach (Subfield subfield in field.subfields)
                {
                    if ((subfield.Name == fieldName) && (!checkMesgSupportForSubFields || (subfield.CanMesgSupport(this))))
                    {
                        return field;
                    }
                }
            }
            return null;
        }

        public ushort GetActiveSubFieldIndex(byte fieldNum)
        {
            Field testField = new Field(this.GetField(fieldNum));

            for (ushort i = 0; i < testField.subfields.Count; i++)
            {
                if (testField.subfields[i].CanMesgSupport(this))
                {
                    return i;
                }
            }
            return Fit.SubfieldIndexMainField;
        }

        public string GetActiveSubFieldName(byte fieldNum)
        {
            Field testField = new Field(this.GetField(fieldNum));

            foreach (Subfield subfield in testField.subfields)
            {
                if (subfield.CanMesgSupport(this))
                {
                    return subfield.Name;
                }
            }
            return Fit.SubfieldNameMainField;
        }

        /// <summary>
        /// Removes the specified field from this message.
        /// </summary>
        /// <param name="field">The Field to be removed from this message.</param>
        public void RemoveField(Field field)
        {
            FieldsList.Remove(field);
        }
        #endregion

        public int GetNumFieldValues(byte fieldNum)
        {
            Field field = GetField(fieldNum);

            if (field != null)
            {
                return field.GetNumValues();
            }
            return 0;
        }

        public int GetNumFieldValues(String fieldName)
        {
            Field field = GetField(fieldName);

            if (field != null)
            {
                return field.GetNumValues();
            }
            return 0;
        }

        public int GetNumFieldValues(byte fieldNum, ushort subfieldIndex)
        {
            Field field = GetField(fieldNum);

            if (field == null)
            {
                return 0;
            }

            if (subfieldIndex == Fit.SubfieldIndexActiveSubfield)
            {
                return field.GetNumValues();
            }

            Subfield subfield = field.GetSubfield(subfieldIndex);
            if ((subfield == null) || (subfield.CanMesgSupport(this)))
            {
                return field.GetNumValues();
            }
            else
            {
                return 0;
            }
        }

        public int GetNumFieldValues(byte fieldNum, string subfieldName)
        {
            Field field = GetField(fieldNum);

            if (field == null)
            {
                return 0;
            }

            Subfield subfield = field.GetSubfield(subfieldName);
            if ((subfield == null) || (subfield.CanMesgSupport(this)))
            {
                return field.GetNumValues();
            }
            else
            {
                return 0;
            }
        }

        public object GetFieldValue(byte fieldNum)
        {
            return GetFieldValue(fieldNum, 0, Fit.SubfieldIndexActiveSubfield);
        }

        public object GetFieldValue(byte fieldNum, int fieldArrayIndex)
        {
            return GetFieldValue(fieldNum, fieldArrayIndex, Fit.SubfieldIndexActiveSubfield);
        }

        public object GetFieldValue(byte fieldNum, int fieldArrayIndex, ushort subFieldIndex)
        {
            Field field = GetField(fieldNum);

            if (field == null)
            {
                return null;
            }

            if (subFieldIndex == Fit.SubfieldIndexActiveSubfield)
            {
                return field.GetValue(fieldArrayIndex, GetActiveSubFieldIndex(fieldNum));
            }
            else
            {
                Subfield subfield = field.GetSubfield(subFieldIndex);

                if ((subfield == null) || (subfield.CanMesgSupport(this)))
                {
                    return field.GetValue(fieldArrayIndex, subFieldIndex);
                }
                else
                {
                    return null;
                }
            }
        }

        public object GetFieldValue(byte fieldNum, int fieldArrayIndex, string subfieldName)
        {
            Field field = GetField(fieldNum);

            if (field == null)
            {
                return null;
            }

            Subfield subfield = field.GetSubfield(subfieldName);

            if ((subfield == null) || (subfield.CanMesgSupport(this)))
            {
                return field.GetValue(fieldArrayIndex, subfieldName);
            }
            else
            {
                return null;
            }
        }

        public object GetFieldValue(string name)
        {
            return GetFieldValue(name, 0);
        }

        public object GetFieldValue(string name, int fieldArrayIndex)
        {
            Field field = GetField(name, false);

            if (field == null)
            {
                return null;
            }

            Subfield subfield = field.GetSubfield(name);

            if ((subfield == null) || (subfield.CanMesgSupport(this)))
            {
                return field.GetValue(fieldArrayIndex, name);
            }
            else
            {
                return null;
            }
        }

        public bool GetIsFieldAccumulated(byte num)
        {
            Field field = GetField(num);
            if (field != null)
            {
                return field.IsAccumulated;
            }
            return false;
        }

        public void SetFieldValue(byte fieldNum, Object value)
        {
            SetFieldValue(fieldNum, 0, value, Fit.SubfieldIndexActiveSubfield);
        }

        public void SetFieldValue(byte fieldNum, int fieldArrayIndex, Object value)
        {
            SetFieldValue(fieldNum, fieldArrayIndex, value, Fit.SubfieldIndexActiveSubfield);
        }

        public void SetFieldValue(byte fieldNum, int fieldArrayIndex, Object value, ushort subfieldIndex)
        {
            if (subfieldIndex == Fit.SubfieldIndexActiveSubfield)
            {
                subfieldIndex = GetActiveSubFieldIndex(fieldNum);
            }
            else
            {
                Field testField = new Field(this.GetField(fieldNum));
                Subfield subfield = testField.GetSubfield(subfieldIndex);

                if ((subfield != null) && !(subfield.CanMesgSupport(this)))
                {
                    return;
                }
            }

            Field field = GetField(fieldNum);

            if (field == null)
            {
                // We normally won't have fields attached to our skeleton message,
                // as we add values we need to add the fields too based on the mesg,field
                // combo in the profile.
                field = new Field(Profile.GetMesg(this.Num).GetField(fieldNum));
                if (field.Num == Fit.FieldNumInvalid)
                {
                    // If there was no info in the profile our FieldNum will get set to invalid,
                    // at least preserve FieldNum while we know it
                    field.Num = fieldNum;
                }
                SetField(field);
            }
            field.SetValue(fieldArrayIndex, value, subfieldIndex);
        }

        public void SetFieldValue(byte fieldNum, int fieldArrayIndex, Object value, String subfieldName)
        {
            Field testField = new Field(this.GetField(fieldNum));
            Subfield subfield = testField.GetSubfield(subfieldName);

            if ((subfield != null) && !(subfield.CanMesgSupport(this)))
            {
                return;
            }

            Field field = GetField(fieldNum);

            if (field == null)
            {
                // We normally won't have fields attached to our skeleton message,
                // as we add values we need to add the fields too based on the mesg,field
                // combo in the profile.
                field = new Field(Profile.GetMesg(this.Num).GetField(fieldNum));
                if (field.Num == Fit.FieldNumInvalid)
                {
                    // If there was no info in the profile our FieldNum will get set to invalid,
                    // at least preserve FieldNum while we know it
                    field.Num = fieldNum;
                }
                SetField(field);
            }
            field.SetValue(fieldArrayIndex, value, subfieldName);
        }

        public void SetFieldValue(String name, Object value)
        {
            SetFieldValue(name, 0, value);
        }

        public void SetFieldValue(String name, int fieldArrayIndex, Object value)
        {
            Field testField = new Field(this.GetField(name));
            Subfield subfield = testField.GetSubfield(name);

            if ((subfield != null) && !(subfield.CanMesgSupport(this)))
            {
                return;
            }

            Field field = GetField(name, false);

            if (field == null)
            {
                field = new Field(Profile.GetMesg(this.Num).GetField(name));
                SetField(field);
            }

            field.SetValue(fieldArrayIndex, value, name);
        }

        public DateTime TimestampToDateTime(uint timestamp)
        {
            DateTime dateTime = new DateTime(timestamp);
            dateTime.ConvertSystemTimeToUTC(systemTimeOffset);

            return dateTime;
        }

        public DateTime TimestampToDateTime(uint? timestamp)
        {
            DateTime dateTime = null;
            if (timestamp != null)
            {
                dateTime = new DateTime(timestamp ?? 0);
                dateTime.ConvertSystemTimeToUTC(systemTimeOffset);
            }

            return dateTime;
        }

        /// <summary>
        /// Removes all fields from this message that have been generated through
        /// component expansion while decoding the source .FIT file.
        /// </summary>
        public void RemoveExpandedFields()
        {
            fields.RemoveAll(x => x.IsExpandedField);
        }

        private IEnumerable<FieldComponentExpansion> ExpandComponentsInList(List<FieldComponent> componentList, Field currentField, int offset, Accumulator accumulator)
        {
            // When components.Count > 0 a field will be created and appended to the field list
            if ((componentList != null) && (componentList.Count > 0))
            {
                foreach (FieldComponent fC in componentList)
                {
                    if (fC.fieldNum != Fit.FieldNumInvalid)
                    {
                        //Create a new field to expand into
                        Field newField = new Field(Profile.GetMesg(this.Num).GetField(fC.fieldNum));

                        // Mark that this field has been generated through expansion
                        newField.IsExpandedField = true;

                        //cache a field that we use to set properties on
                        Field f = this.GetField(newField.Num);

                        // GetBitsValue will not return more bits than the componentField type can hold.
                        // This means strings are built one letter at a time when using components
                        // which is a bad idea to start with)
                        long? bitsValue = currentField.GetBitsValue(offset, fC.bits, newField.Type);
                        if (bitsValue == null)
                        {
                            break;
                        }

                        if (true == fC.accumulate)
                        {
                            bitsValue = accumulator.Accumulate(this.Num, fC.fieldNum, bitsValue.Value, fC.bits);
                        }

                        if (newField.IsNumeric())
                        {
                            // If the field is invalid, set the raw value so that
                            // the invalid value is not scaled or offset.
                            if (FitBaseType.IsNumericInvalid((long)bitsValue, newField.GetType()))
                            {
                                if (this.HasField(newField.Num))
                                {
                                    f.SetRawValue(f.GetNumValues(), bitsValue);
                                }
                                else
                                {
                                    newField.SetRawValue(0, bitsValue);
                                }
                            }
                            else
                            {
                                double fbitsValue = Convert.ToDouble(bitsValue);

                                fbitsValue = ((double)fbitsValue / fC.scale) - fC.offset;

                                if (this.HasField(newField.Num))
                                {
                                    f.SetValue(f.GetNumValues(), fbitsValue);
                                }
                                else
                                {
                                    newField.SetValue(fbitsValue);
                                }
                            }
                        }
                        // Shouldn't apply scale/offset to string or enum
                        else
                        {
                            object nonNumericBitsValue;
                            // Ensure strings are added as byte[]
                            if ((newField.Type & Fit.BaseTypeNumMask) == Fit.String)
                            {
                                nonNumericBitsValue = new byte[] { (byte)bitsValue };
                            }
                            else
                            {
                                nonNumericBitsValue = bitsValue;
                            }
                            if (HasField(newField.Num))
                            {
                                f.SetValue(f.GetNumValues(), nonNumericBitsValue);
                            }
                            else
                            {
                                newField.SetValue(nonNumericBitsValue);
                            }
                        }
                        offset += fC.bits;

                        //Return each field as we iterate
                        yield return new FieldComponentExpansion(newField, offset);
                    }
                }
            }
        }

        public void ExpandComponents()
        {
            ExpandComponents(null);
        }

        public void ExpandComponents(Accumulator accumulator)
        {
            // Traverse the field list
            // Change to for loop so we can add items as we iterate
            for (int i = 0; i < FieldsList.Count; ++i)
            {
                List<FieldComponent> componentList = null;
                // Determine the active subfield
                ushort activeSubfield = GetActiveSubFieldIndex(FieldsList[i].Num);

                if (activeSubfield == Fit.SubfieldIndexMainField)
                {
                    componentList = FieldsList[i].components;
                }
                else
                {
                    componentList = FieldsList[i].GetSubfield(activeSubfield).Components;
                }

                // Traverse the component list
                int offset = 0;
                foreach (FieldComponentExpansion f in ExpandComponentsInList(componentList, FieldsList[i], offset, accumulator))
                {
                    //Add the new field
                    FieldsList.Add(f.GetField());
                    //update offset
                    offset = f.GetOffset();
                }
            }
        }
        #endregion
    }

    internal class FieldComponentExpansion
    {
        private int offset;
        private Field field;

        public FieldComponentExpansion(Field f, int offset)
        {
            field = f;
            this.offset = offset;
        }

        public int GetOffset()
        {
            return offset;
        }

        public Field GetField()
        {
            return field;
        }
    }
} // namespace

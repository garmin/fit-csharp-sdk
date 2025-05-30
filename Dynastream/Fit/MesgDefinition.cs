#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2025 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.171.0Release
// Tag = production/release/21.171.0-0-g57fed75
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;
using Dynastream.Utility;

namespace Dynastream.Fit
{
    /// <summary>
    /// Architecture defaults to Little Endian (unless decoded from an binary defn as Big Endian)
    /// This could be exposed in the future to programatically create BE streams.
    /// </summary>
    public class MesgDefinition
    {
        #region Fields
        private byte architecture;
        private byte localMesgNum;
        private List<FieldDefinition> fieldDefs = new List<FieldDefinition>();
        private readonly List<DeveloperFieldDefinition> m_devFieldDefs =
            new List<DeveloperFieldDefinition>();
        private byte header;
        #endregion

        #region Properties
        public ushort GlobalMesgNum { get; set; }
        public byte LocalMesgNum
        {
            get
            {
                return localMesgNum;
            }
            set
            {
                if (value > Fit.LocalMesgNumMask)
                {
                    throw new FitException("MesgDefinition:LocalMesgNum - Invalid Local message number " + value + ". Local message number must be < " + Fit.LocalMesgNumMask);
                }
                else
                {
                    localMesgNum = value;
                }
            }
        }

        public byte NumDevFields
        {
            get { return (byte)m_devFieldDefs.Count; }
        }

        public byte NumFields { get; set; }

        public bool IsBigEndian
        {
            get
            {
                return architecture == Fit.BigEndian;
            }
        }

        private bool ContainsDevData
        {
            get { return (header & Fit.DevDataMask) == Fit.DevDataMask; }
        }

        internal IEnumerable<DeveloperFieldDefinition> DeveloperFieldDefinitions
        {
            get
            {
                return m_devFieldDefs;
            }
        }

        #endregion

        #region Constructors
        internal MesgDefinition()
        {
            LocalMesgNum = 0;
            GlobalMesgNum = (ushort)MesgNum.Invalid;
            architecture = Fit.LittleEndian;
        }

        internal MesgDefinition(
            Stream fitSource,
            DeveloperDataLookup lookup)
        {
            Read(fitSource, lookup);
        }

        public MesgDefinition(Stream fitSource)
            : this(fitSource, null)
        {
        }

        public MesgDefinition(Mesg mesg)
        {
            LocalMesgNum = mesg.LocalNum;
            GlobalMesgNum = mesg.Num;
            architecture = Fit.LittleEndian;
            NumFields = (byte)mesg.FieldsList.Count;

            foreach (Field field in mesg.FieldsList)
            {
                fieldDefs.Add(new FieldDefinition(field));
            }

            foreach (DeveloperField field in mesg.DeveloperFields)
            {
                m_devFieldDefs.Add(new DeveloperFieldDefinition(
                    field.Num,
                    field.GetSize(),
                    field.DeveloperDataIndex));
            }
        }

        public MesgDefinition(MesgDefinition mesgDef)
        {
            LocalMesgNum = mesgDef.LocalMesgNum;
            GlobalMesgNum = mesgDef.GlobalMesgNum;
            architecture = mesgDef.IsBigEndian ? Fit.BigEndian : Fit.LittleEndian;
            NumFields = mesgDef.NumFields;

            foreach (FieldDefinition fieldDef in mesgDef.fieldDefs)
            {
                fieldDefs.Add(new FieldDefinition(fieldDef));
            }

            m_devFieldDefs.AddRange(mesgDef.m_devFieldDefs);
        }
        #endregion

        #region Methods

        internal void Read(Stream fitSource, DeveloperDataLookup lookup)
        {
            fitSource.Position = 0;
            EndianBinaryReader br = new EndianBinaryReader(fitSource, false);

            header = br.ReadByte();
            LocalMesgNum = (byte)(header & Fit.LocalMesgNumMask);

            byte reserved = br.ReadByte();
            architecture = br.ReadByte();
            br.IsBigEndian = this.IsBigEndian;
            GlobalMesgNum = br.ReadUInt16();
            NumFields = br.ReadByte();
            for (int i = 0; i < NumFields; i++)
            {
                byte num = br.ReadByte();
                byte size = br.ReadByte();
                byte type = br.ReadByte();

                FieldDefinition newField = new FieldDefinition(num, size, type);
                fieldDefs.Add(newField);
            }

            if (ContainsDevData)
            {
                byte devFldCount = br.ReadByte();
                for (int i = 0; i < devFldCount; i++)
                {
                    // Seek to the Size
                    byte num = br.ReadByte();
                    byte size = br.ReadByte();
                    byte devIdx = br.ReadByte();
                    DeveloperFieldDefinition defn;
                    var key = new DeveloperDataKey(devIdx, num);
                    Tuple<DeveloperDataIdMesg, FieldDescriptionMesg> tuple = lookup.GetMesgs(key);

                    if (tuple != null)
                    {
                        defn = new DeveloperFieldDefinition(tuple.Item2, tuple.Item1, size);
                    }
                    else
                    {
                        defn = new DeveloperFieldDefinition(num, size, devIdx);
                    }

                    m_devFieldDefs.Add(defn);
                }
            }
        }

        public void Write(Stream fitDest)
        {
            BinaryWriter bw = new BinaryWriter(fitDest);
            byte header = LocalMesgNum;
            header |= Fit.MesgDefinitionMask;
            header |= NumDevFields > 0 ? Fit.DevDataMask : (byte)0x00;

            bw.Write(header);
            bw.Write(Fit.MesgDefinitionReserved);
            bw.Write(Fit.LittleEndian);
            bw.Write(GlobalMesgNum);
            bw.Write(NumFields);

            if (NumFields != fieldDefs.Count)
            {
                throw new FitException("MesgDefinition:Write - Field Count Internal Error");
            }

            foreach (FieldDefinition def in fieldDefs)
            {
                bw.Write(def.Num);
                bw.Write(def.Size);
                bw.Write(def.Type);
            }

            if (NumDevFields > 0)
            {
                bw.Write(NumDevFields);
            }

            foreach (DeveloperFieldDefinition def in m_devFieldDefs)
            {
                bw.Write(def.FieldNum);
                bw.Write(def.Size);
                bw.Write(def.DeveloperDataIndex);
            }
        }

        public int GetMesgSize()
        {
            int mesgSize = 1;  // header

            mesgSize += fieldDefs.Sum(x => x.Size);
            mesgSize += m_devFieldDefs.Sum(x => x.Size);

            return mesgSize;
        }

        public void AddField(FieldDefinition field)
        {
            fieldDefs.Add(field);
        }

        public void ClearFields()
        {
            fieldDefs.Clear();
        }

        public int GetNumFields()
        {
            return fieldDefs.Count;
        }

        public List<FieldDefinition> GetFields()
        {
            // This is a reference to the real list
            return fieldDefs;
        }

        public FieldDefinition GetField(byte num)
        {
            foreach (FieldDefinition fieldDef in fieldDefs)
            {
                if (fieldDef.Num == num)
                {
                    return fieldDef;
                }
            }
            return null;
        }

        internal DeveloperFieldDefinition GetDeveloperFieldDefinition(byte num, byte developerIndex)
        {
            return
                m_devFieldDefs.FirstOrDefault(
                    def => (def.FieldNum == num) && (def.DeveloperDataIndex == developerIndex));
        }

        public bool Supports(Mesg mesg)
        {
            return Supports(new MesgDefinition(mesg));
        }

        public bool Supports(MesgDefinition mesgDef)
        {
            if (mesgDef == null)
            {
                return false;
            }

            if (GlobalMesgNum != mesgDef.GlobalMesgNum)
            {
                return false;
            }

            if (LocalMesgNum != mesgDef.LocalMesgNum)
            {
                return false;
            }

            foreach (FieldDefinition fieldDef in mesgDef.GetFields())
            {
                FieldDefinition supportedFieldDef = GetField(fieldDef.Num);

                if (supportedFieldDef == null)
                {
                    return false;
                }

                if (fieldDef.Size > supportedFieldDef.Size)
                {
                    return false;
                }
            }

            foreach (DeveloperFieldDefinition fieldDef in mesgDef.DeveloperFieldDefinitions)
            {
                var supportedFieldDef =
                    GetDeveloperFieldDefinition(fieldDef.FieldNum, fieldDef.DeveloperDataIndex);

                if (supportedFieldDef == null)
                {
                    return false;
                }

                if (fieldDef.Size > supportedFieldDef.Size)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
} // namespace

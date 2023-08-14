#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.119Release
// Tag = production/release/21.119.00-0-gf97dcb5
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the BikeProfile profile message.
    /// </summary>
    public class BikeProfileMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="BikeProfileMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Name = 0;
            public const byte Sport = 1;
            public const byte SubSport = 2;
            public const byte Odometer = 3;
            public const byte BikeSpdAntId = 4;
            public const byte BikeCadAntId = 5;
            public const byte BikeSpdcadAntId = 6;
            public const byte BikePowerAntId = 7;
            public const byte CustomWheelsize = 8;
            public const byte AutoWheelsize = 9;
            public const byte BikeWeight = 10;
            public const byte PowerCalFactor = 11;
            public const byte AutoWheelCal = 12;
            public const byte AutoPowerZero = 13;
            public const byte Id = 14;
            public const byte SpdEnabled = 15;
            public const byte CadEnabled = 16;
            public const byte SpdcadEnabled = 17;
            public const byte PowerEnabled = 18;
            public const byte CrankLength = 19;
            public const byte Enabled = 20;
            public const byte BikeSpdAntIdTransType = 21;
            public const byte BikeCadAntIdTransType = 22;
            public const byte BikeSpdcadAntIdTransType = 23;
            public const byte BikePowerAntIdTransType = 24;
            public const byte OdometerRollover = 37;
            public const byte FrontGearNum = 38;
            public const byte FrontGear = 39;
            public const byte RearGearNum = 40;
            public const byte RearGear = 41;
            public const byte ShimanoDi2Enabled = 44;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public BikeProfileMesg() : base(Profile.GetMesg(MesgNum.BikeProfile))
        {
        }

        public BikeProfileMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns byte[] representing the Name field</returns>
        public byte[] GetName()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns String representing the Name field</returns>
        public String GetNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Name field</summary>
        /// <param name="name_"> field value to be set</param>
        public void SetName(String name_)
        {
            byte[] data = Encoding.UTF8.GetBytes(name_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(0, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Name field</summary>
        /// <param name="name_">field value to be set</param>
        public void SetName(byte[] name_)
        {
            SetFieldValue(0, 0, name_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>
        public Sport? GetSport()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            Sport? value = obj == null ? (Sport?)null : (Sport)obj;
            return value;
        }

        /// <summary>
        /// Set Sport field</summary>
        /// <param name="sport_">Nullable field value to be set</param>
        public void SetSport(Sport? sport_)
        {
            SetFieldValue(1, 0, sport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SubSport field</summary>
        /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>
        public SubSport? GetSubSport()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set SubSport field</summary>
        /// <param name="subSport_">Nullable field value to be set</param>
        public void SetSubSport(SubSport? subSport_)
        {
            SetFieldValue(2, 0, subSport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Odometer field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Odometer field</returns>
        public float? GetOdometer()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Odometer field
        /// Units: m</summary>
        /// <param name="odometer_">Nullable field value to be set</param>
        public void SetOdometer(float? odometer_)
        {
            SetFieldValue(3, 0, odometer_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeSpdAntId field</summary>
        /// <returns>Returns nullable ushort representing the BikeSpdAntId field</returns>
        public ushort? GetBikeSpdAntId()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set BikeSpdAntId field</summary>
        /// <param name="bikeSpdAntId_">Nullable field value to be set</param>
        public void SetBikeSpdAntId(ushort? bikeSpdAntId_)
        {
            SetFieldValue(4, 0, bikeSpdAntId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeCadAntId field</summary>
        /// <returns>Returns nullable ushort representing the BikeCadAntId field</returns>
        public ushort? GetBikeCadAntId()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set BikeCadAntId field</summary>
        /// <param name="bikeCadAntId_">Nullable field value to be set</param>
        public void SetBikeCadAntId(ushort? bikeCadAntId_)
        {
            SetFieldValue(5, 0, bikeCadAntId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeSpdcadAntId field</summary>
        /// <returns>Returns nullable ushort representing the BikeSpdcadAntId field</returns>
        public ushort? GetBikeSpdcadAntId()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set BikeSpdcadAntId field</summary>
        /// <param name="bikeSpdcadAntId_">Nullable field value to be set</param>
        public void SetBikeSpdcadAntId(ushort? bikeSpdcadAntId_)
        {
            SetFieldValue(6, 0, bikeSpdcadAntId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikePowerAntId field</summary>
        /// <returns>Returns nullable ushort representing the BikePowerAntId field</returns>
        public ushort? GetBikePowerAntId()
        {
            Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set BikePowerAntId field</summary>
        /// <param name="bikePowerAntId_">Nullable field value to be set</param>
        public void SetBikePowerAntId(ushort? bikePowerAntId_)
        {
            SetFieldValue(7, 0, bikePowerAntId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CustomWheelsize field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the CustomWheelsize field</returns>
        public float? GetCustomWheelsize()
        {
            Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CustomWheelsize field
        /// Units: m</summary>
        /// <param name="customWheelsize_">Nullable field value to be set</param>
        public void SetCustomWheelsize(float? customWheelsize_)
        {
            SetFieldValue(8, 0, customWheelsize_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutoWheelsize field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the AutoWheelsize field</returns>
        public float? GetAutoWheelsize()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set AutoWheelsize field
        /// Units: m</summary>
        /// <param name="autoWheelsize_">Nullable field value to be set</param>
        public void SetAutoWheelsize(float? autoWheelsize_)
        {
            SetFieldValue(9, 0, autoWheelsize_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeWeight field
        /// Units: kg</summary>
        /// <returns>Returns nullable float representing the BikeWeight field</returns>
        public float? GetBikeWeight()
        {
            Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BikeWeight field
        /// Units: kg</summary>
        /// <param name="bikeWeight_">Nullable field value to be set</param>
        public void SetBikeWeight(float? bikeWeight_)
        {
            SetFieldValue(10, 0, bikeWeight_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PowerCalFactor field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the PowerCalFactor field</returns>
        public float? GetPowerCalFactor()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set PowerCalFactor field
        /// Units: %</summary>
        /// <param name="powerCalFactor_">Nullable field value to be set</param>
        public void SetPowerCalFactor(float? powerCalFactor_)
        {
            SetFieldValue(11, 0, powerCalFactor_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutoWheelCal field</summary>
        /// <returns>Returns nullable Bool enum representing the AutoWheelCal field</returns>
        public Bool? GetAutoWheelCal()
        {
            object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set AutoWheelCal field</summary>
        /// <param name="autoWheelCal_">Nullable field value to be set</param>
        public void SetAutoWheelCal(Bool? autoWheelCal_)
        {
            SetFieldValue(12, 0, autoWheelCal_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutoPowerZero field</summary>
        /// <returns>Returns nullable Bool enum representing the AutoPowerZero field</returns>
        public Bool? GetAutoPowerZero()
        {
            object obj = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set AutoPowerZero field</summary>
        /// <param name="autoPowerZero_">Nullable field value to be set</param>
        public void SetAutoPowerZero(Bool? autoPowerZero_)
        {
            SetFieldValue(13, 0, autoPowerZero_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Id field</summary>
        /// <returns>Returns nullable byte representing the Id field</returns>
        public byte? GetId()
        {
            Object val = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Id field</summary>
        /// <param name="id_">Nullable field value to be set</param>
        public void SetId(byte? id_)
        {
            SetFieldValue(14, 0, id_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SpdEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the SpdEnabled field</returns>
        public Bool? GetSpdEnabled()
        {
            object obj = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set SpdEnabled field</summary>
        /// <param name="spdEnabled_">Nullable field value to be set</param>
        public void SetSpdEnabled(Bool? spdEnabled_)
        {
            SetFieldValue(15, 0, spdEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CadEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the CadEnabled field</returns>
        public Bool? GetCadEnabled()
        {
            object obj = GetFieldValue(16, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set CadEnabled field</summary>
        /// <param name="cadEnabled_">Nullable field value to be set</param>
        public void SetCadEnabled(Bool? cadEnabled_)
        {
            SetFieldValue(16, 0, cadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SpdcadEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the SpdcadEnabled field</returns>
        public Bool? GetSpdcadEnabled()
        {
            object obj = GetFieldValue(17, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set SpdcadEnabled field</summary>
        /// <param name="spdcadEnabled_">Nullable field value to be set</param>
        public void SetSpdcadEnabled(Bool? spdcadEnabled_)
        {
            SetFieldValue(17, 0, spdcadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PowerEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the PowerEnabled field</returns>
        public Bool? GetPowerEnabled()
        {
            object obj = GetFieldValue(18, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set PowerEnabled field</summary>
        /// <param name="powerEnabled_">Nullable field value to be set</param>
        public void SetPowerEnabled(Bool? powerEnabled_)
        {
            SetFieldValue(18, 0, powerEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CrankLength field
        /// Units: mm</summary>
        /// <returns>Returns nullable float representing the CrankLength field</returns>
        public float? GetCrankLength()
        {
            Object val = GetFieldValue(19, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CrankLength field
        /// Units: mm</summary>
        /// <param name="crankLength_">Nullable field value to be set</param>
        public void SetCrankLength(float? crankLength_)
        {
            SetFieldValue(19, 0, crankLength_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Enabled field</summary>
        /// <returns>Returns nullable Bool enum representing the Enabled field</returns>
        public Bool? GetEnabled()
        {
            object obj = GetFieldValue(20, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Enabled field</summary>
        /// <param name="enabled_">Nullable field value to be set</param>
        public void SetEnabled(Bool? enabled_)
        {
            SetFieldValue(20, 0, enabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeSpdAntIdTransType field</summary>
        /// <returns>Returns nullable byte representing the BikeSpdAntIdTransType field</returns>
        public byte? GetBikeSpdAntIdTransType()
        {
            Object val = GetFieldValue(21, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BikeSpdAntIdTransType field</summary>
        /// <param name="bikeSpdAntIdTransType_">Nullable field value to be set</param>
        public void SetBikeSpdAntIdTransType(byte? bikeSpdAntIdTransType_)
        {
            SetFieldValue(21, 0, bikeSpdAntIdTransType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeCadAntIdTransType field</summary>
        /// <returns>Returns nullable byte representing the BikeCadAntIdTransType field</returns>
        public byte? GetBikeCadAntIdTransType()
        {
            Object val = GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BikeCadAntIdTransType field</summary>
        /// <param name="bikeCadAntIdTransType_">Nullable field value to be set</param>
        public void SetBikeCadAntIdTransType(byte? bikeCadAntIdTransType_)
        {
            SetFieldValue(22, 0, bikeCadAntIdTransType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikeSpdcadAntIdTransType field</summary>
        /// <returns>Returns nullable byte representing the BikeSpdcadAntIdTransType field</returns>
        public byte? GetBikeSpdcadAntIdTransType()
        {
            Object val = GetFieldValue(23, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BikeSpdcadAntIdTransType field</summary>
        /// <param name="bikeSpdcadAntIdTransType_">Nullable field value to be set</param>
        public void SetBikeSpdcadAntIdTransType(byte? bikeSpdcadAntIdTransType_)
        {
            SetFieldValue(23, 0, bikeSpdcadAntIdTransType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BikePowerAntIdTransType field</summary>
        /// <returns>Returns nullable byte representing the BikePowerAntIdTransType field</returns>
        public byte? GetBikePowerAntIdTransType()
        {
            Object val = GetFieldValue(24, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BikePowerAntIdTransType field</summary>
        /// <param name="bikePowerAntIdTransType_">Nullable field value to be set</param>
        public void SetBikePowerAntIdTransType(byte? bikePowerAntIdTransType_)
        {
            SetFieldValue(24, 0, bikePowerAntIdTransType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the OdometerRollover field
        /// Comment: Rollover counter that can be used to extend the odometer</summary>
        /// <returns>Returns nullable byte representing the OdometerRollover field</returns>
        public byte? GetOdometerRollover()
        {
            Object val = GetFieldValue(37, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set OdometerRollover field
        /// Comment: Rollover counter that can be used to extend the odometer</summary>
        /// <param name="odometerRollover_">Nullable field value to be set</param>
        public void SetOdometerRollover(byte? odometerRollover_)
        {
            SetFieldValue(37, 0, odometerRollover_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FrontGearNum field
        /// Comment: Number of front gears</summary>
        /// <returns>Returns nullable byte representing the FrontGearNum field</returns>
        public byte? GetFrontGearNum()
        {
            Object val = GetFieldValue(38, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set FrontGearNum field
        /// Comment: Number of front gears</summary>
        /// <param name="frontGearNum_">Nullable field value to be set</param>
        public void SetFrontGearNum(byte? frontGearNum_)
        {
            SetFieldValue(38, 0, frontGearNum_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field FrontGear</returns>
        public int GetNumFrontGear()
        {
            return GetNumFieldValues(39, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the FrontGear field
        /// Comment: Number of teeth on each gear 0 is innermost</summary>
        /// <param name="index">0 based index of FrontGear element to retrieve</param>
        /// <returns>Returns nullable byte representing the FrontGear field</returns>
        public byte? GetFrontGear(int index)
        {
            Object val = GetFieldValue(39, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set FrontGear field
        /// Comment: Number of teeth on each gear 0 is innermost</summary>
        /// <param name="index">0 based index of front_gear</param>
        /// <param name="frontGear_">Nullable field value to be set</param>
        public void SetFrontGear(int index, byte? frontGear_)
        {
            SetFieldValue(39, index, frontGear_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the RearGearNum field
        /// Comment: Number of rear gears</summary>
        /// <returns>Returns nullable byte representing the RearGearNum field</returns>
        public byte? GetRearGearNum()
        {
            Object val = GetFieldValue(40, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set RearGearNum field
        /// Comment: Number of rear gears</summary>
        /// <param name="rearGearNum_">Nullable field value to be set</param>
        public void SetRearGearNum(byte? rearGearNum_)
        {
            SetFieldValue(40, 0, rearGearNum_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field RearGear</returns>
        public int GetNumRearGear()
        {
            return GetNumFieldValues(41, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the RearGear field
        /// Comment: Number of teeth on each gear 0 is innermost</summary>
        /// <param name="index">0 based index of RearGear element to retrieve</param>
        /// <returns>Returns nullable byte representing the RearGear field</returns>
        public byte? GetRearGear(int index)
        {
            Object val = GetFieldValue(41, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set RearGear field
        /// Comment: Number of teeth on each gear 0 is innermost</summary>
        /// <param name="index">0 based index of rear_gear</param>
        /// <param name="rearGear_">Nullable field value to be set</param>
        public void SetRearGear(int index, byte? rearGear_)
        {
            SetFieldValue(41, index, rearGear_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ShimanoDi2Enabled field</summary>
        /// <returns>Returns nullable Bool enum representing the ShimanoDi2Enabled field</returns>
        public Bool? GetShimanoDi2Enabled()
        {
            object obj = GetFieldValue(44, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set ShimanoDi2Enabled field</summary>
        /// <param name="shimanoDi2Enabled_">Nullable field value to be set</param>
        public void SetShimanoDi2Enabled(Bool? shimanoDi2Enabled_)
        {
            SetFieldValue(44, 0, shimanoDi2Enabled_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

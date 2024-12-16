#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.158.0Release
// Tag = production/release/21.158.0-0-gc9428aa
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
    /// Implements the TimeInZone profile message.
    /// </summary>
    public class TimeInZoneMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="TimeInZoneMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte ReferenceMesg = 0;
            public const byte ReferenceIndex = 1;
            public const byte TimeInHrZone = 2;
            public const byte TimeInSpeedZone = 3;
            public const byte TimeInCadenceZone = 4;
            public const byte TimeInPowerZone = 5;
            public const byte HrZoneHighBoundary = 6;
            public const byte SpeedZoneHighBoundary = 7;
            public const byte CadenceZoneHighBondary = 8;
            public const byte PowerZoneHighBoundary = 9;
            public const byte HrCalcType = 10;
            public const byte MaxHeartRate = 11;
            public const byte RestingHeartRate = 12;
            public const byte ThresholdHeartRate = 13;
            public const byte PwrCalcType = 14;
            public const byte FunctionalThresholdPower = 15;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public TimeInZoneMesg() : base(Profile.GetMesg(MesgNum.TimeInZone))
        {
        }

        public TimeInZoneMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field
        /// Units: s</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ReferenceMesg field</summary>
        /// <returns>Returns nullable ushort representing the ReferenceMesg field</returns>
        public ushort? GetReferenceMesg()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ReferenceMesg field</summary>
        /// <param name="referenceMesg_">Nullable field value to be set</param>
        public void SetReferenceMesg(ushort? referenceMesg_)
        {
            SetFieldValue(0, 0, referenceMesg_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ReferenceIndex field</summary>
        /// <returns>Returns nullable ushort representing the ReferenceIndex field</returns>
        public ushort? GetReferenceIndex()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ReferenceIndex field</summary>
        /// <param name="referenceIndex_">Nullable field value to be set</param>
        public void SetReferenceIndex(ushort? referenceIndex_)
        {
            SetFieldValue(1, 0, referenceIndex_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeInHrZone</returns>
        public int GetNumTimeInHrZone()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeInHrZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInHrZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInHrZone field</returns>
        public float? GetTimeInHrZone(int index)
        {
            Object val = GetFieldValue(2, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TimeInHrZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of time_in_hr_zone</param>
        /// <param name="timeInHrZone_">Nullable field value to be set</param>
        public void SetTimeInHrZone(int index, float? timeInHrZone_)
        {
            SetFieldValue(2, index, timeInHrZone_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeInSpeedZone</returns>
        public int GetNumTimeInSpeedZone()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeInSpeedZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInSpeedZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInSpeedZone field</returns>
        public float? GetTimeInSpeedZone(int index)
        {
            Object val = GetFieldValue(3, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TimeInSpeedZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of time_in_speed_zone</param>
        /// <param name="timeInSpeedZone_">Nullable field value to be set</param>
        public void SetTimeInSpeedZone(int index, float? timeInSpeedZone_)
        {
            SetFieldValue(3, index, timeInSpeedZone_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeInCadenceZone</returns>
        public int GetNumTimeInCadenceZone()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeInCadenceZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInCadenceZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInCadenceZone field</returns>
        public float? GetTimeInCadenceZone(int index)
        {
            Object val = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TimeInCadenceZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of time_in_cadence_zone</param>
        /// <param name="timeInCadenceZone_">Nullable field value to be set</param>
        public void SetTimeInCadenceZone(int index, float? timeInCadenceZone_)
        {
            SetFieldValue(4, index, timeInCadenceZone_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeInPowerZone</returns>
        public int GetNumTimeInPowerZone()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeInPowerZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of TimeInPowerZone element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeInPowerZone field</returns>
        public float? GetTimeInPowerZone(int index)
        {
            Object val = GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TimeInPowerZone field
        /// Units: s</summary>
        /// <param name="index">0 based index of time_in_power_zone</param>
        /// <param name="timeInPowerZone_">Nullable field value to be set</param>
        public void SetTimeInPowerZone(int index, float? timeInPowerZone_)
        {
            SetFieldValue(5, index, timeInPowerZone_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field HrZoneHighBoundary</returns>
        public int GetNumHrZoneHighBoundary()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the HrZoneHighBoundary field
        /// Units: bpm</summary>
        /// <param name="index">0 based index of HrZoneHighBoundary element to retrieve</param>
        /// <returns>Returns nullable byte representing the HrZoneHighBoundary field</returns>
        public byte? GetHrZoneHighBoundary(int index)
        {
            Object val = GetFieldValue(6, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set HrZoneHighBoundary field
        /// Units: bpm</summary>
        /// <param name="index">0 based index of hr_zone_high_boundary</param>
        /// <param name="hrZoneHighBoundary_">Nullable field value to be set</param>
        public void SetHrZoneHighBoundary(int index, byte? hrZoneHighBoundary_)
        {
            SetFieldValue(6, index, hrZoneHighBoundary_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field SpeedZoneHighBoundary</returns>
        public int GetNumSpeedZoneHighBoundary()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the SpeedZoneHighBoundary field
        /// Units: m/s</summary>
        /// <param name="index">0 based index of SpeedZoneHighBoundary element to retrieve</param>
        /// <returns>Returns nullable float representing the SpeedZoneHighBoundary field</returns>
        public float? GetSpeedZoneHighBoundary(int index)
        {
            Object val = GetFieldValue(7, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set SpeedZoneHighBoundary field
        /// Units: m/s</summary>
        /// <param name="index">0 based index of speed_zone_high_boundary</param>
        /// <param name="speedZoneHighBoundary_">Nullable field value to be set</param>
        public void SetSpeedZoneHighBoundary(int index, float? speedZoneHighBoundary_)
        {
            SetFieldValue(7, index, speedZoneHighBoundary_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CadenceZoneHighBondary</returns>
        public int GetNumCadenceZoneHighBondary()
        {
            return GetNumFieldValues(8, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CadenceZoneHighBondary field
        /// Units: rpm</summary>
        /// <param name="index">0 based index of CadenceZoneHighBondary element to retrieve</param>
        /// <returns>Returns nullable byte representing the CadenceZoneHighBondary field</returns>
        public byte? GetCadenceZoneHighBondary(int index)
        {
            Object val = GetFieldValue(8, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set CadenceZoneHighBondary field
        /// Units: rpm</summary>
        /// <param name="index">0 based index of cadence_zone_high_bondary</param>
        /// <param name="cadenceZoneHighBondary_">Nullable field value to be set</param>
        public void SetCadenceZoneHighBondary(int index, byte? cadenceZoneHighBondary_)
        {
            SetFieldValue(8, index, cadenceZoneHighBondary_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field PowerZoneHighBoundary</returns>
        public int GetNumPowerZoneHighBoundary()
        {
            return GetNumFieldValues(9, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the PowerZoneHighBoundary field
        /// Units: watts</summary>
        /// <param name="index">0 based index of PowerZoneHighBoundary element to retrieve</param>
        /// <returns>Returns nullable ushort representing the PowerZoneHighBoundary field</returns>
        public ushort? GetPowerZoneHighBoundary(int index)
        {
            Object val = GetFieldValue(9, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set PowerZoneHighBoundary field
        /// Units: watts</summary>
        /// <param name="index">0 based index of power_zone_high_boundary</param>
        /// <param name="powerZoneHighBoundary_">Nullable field value to be set</param>
        public void SetPowerZoneHighBoundary(int index, ushort? powerZoneHighBoundary_)
        {
            SetFieldValue(9, index, powerZoneHighBoundary_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HrCalcType field</summary>
        /// <returns>Returns nullable HrZoneCalc enum representing the HrCalcType field</returns>
        public HrZoneCalc? GetHrCalcType()
        {
            object obj = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            HrZoneCalc? value = obj == null ? (HrZoneCalc?)null : (HrZoneCalc)obj;
            return value;
        }

        /// <summary>
        /// Set HrCalcType field</summary>
        /// <param name="hrCalcType_">Nullable field value to be set</param>
        public void SetHrCalcType(HrZoneCalc? hrCalcType_)
        {
            SetFieldValue(10, 0, hrCalcType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MaxHeartRate field</summary>
        /// <returns>Returns nullable byte representing the MaxHeartRate field</returns>
        public byte? GetMaxHeartRate()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set MaxHeartRate field</summary>
        /// <param name="maxHeartRate_">Nullable field value to be set</param>
        public void SetMaxHeartRate(byte? maxHeartRate_)
        {
            SetFieldValue(11, 0, maxHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the RestingHeartRate field</summary>
        /// <returns>Returns nullable byte representing the RestingHeartRate field</returns>
        public byte? GetRestingHeartRate()
        {
            Object val = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set RestingHeartRate field</summary>
        /// <param name="restingHeartRate_">Nullable field value to be set</param>
        public void SetRestingHeartRate(byte? restingHeartRate_)
        {
            SetFieldValue(12, 0, restingHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ThresholdHeartRate field</summary>
        /// <returns>Returns nullable byte representing the ThresholdHeartRate field</returns>
        public byte? GetThresholdHeartRate()
        {
            Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ThresholdHeartRate field</summary>
        /// <param name="thresholdHeartRate_">Nullable field value to be set</param>
        public void SetThresholdHeartRate(byte? thresholdHeartRate_)
        {
            SetFieldValue(13, 0, thresholdHeartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PwrCalcType field</summary>
        /// <returns>Returns nullable PwrZoneCalc enum representing the PwrCalcType field</returns>
        public PwrZoneCalc? GetPwrCalcType()
        {
            object obj = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            PwrZoneCalc? value = obj == null ? (PwrZoneCalc?)null : (PwrZoneCalc)obj;
            return value;
        }

        /// <summary>
        /// Set PwrCalcType field</summary>
        /// <param name="pwrCalcType_">Nullable field value to be set</param>
        public void SetPwrCalcType(PwrZoneCalc? pwrCalcType_)
        {
            SetFieldValue(14, 0, pwrCalcType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FunctionalThresholdPower field</summary>
        /// <returns>Returns nullable ushort representing the FunctionalThresholdPower field</returns>
        public ushort? GetFunctionalThresholdPower()
        {
            Object val = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set FunctionalThresholdPower field</summary>
        /// <param name="functionalThresholdPower_">Nullable field value to be set</param>
        public void SetFunctionalThresholdPower(ushort? functionalThresholdPower_)
        {
            SetFieldValue(15, 0, functionalThresholdPower_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

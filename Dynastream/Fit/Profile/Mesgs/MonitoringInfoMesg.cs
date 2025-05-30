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

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the MonitoringInfo profile message.
    /// </summary>
    public class MonitoringInfoMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MonitoringInfoMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte LocalTimestamp = 0;
            public const byte ActivityType = 1;
            public const byte CyclesToDistance = 3;
            public const byte CyclesToCalories = 4;
            public const byte RestingMetabolicRate = 5;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MonitoringInfoMesg() : base(Profile.GetMesg(MesgNum.MonitoringInfo))
        {
        }

        public MonitoringInfoMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the LocalTimestamp field
        /// Units: s
        /// Comment: Use to convert activity timestamps to local time if device does not support time zone and daylight savings time correction.</summary>
        /// <returns>Returns nullable uint representing the LocalTimestamp field</returns>
        public uint? GetLocalTimestamp()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set LocalTimestamp field
        /// Units: s
        /// Comment: Use to convert activity timestamps to local time if device does not support time zone and daylight savings time correction.</summary>
        /// <param name="localTimestamp_">Nullable field value to be set</param>
        public void SetLocalTimestamp(uint? localTimestamp_)
        {
            SetFieldValue(0, 0, localTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field ActivityType</returns>
        public int GetNumActivityType()
        {
            return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the ActivityType field</summary>
        /// <param name="index">0 based index of ActivityType element to retrieve</param>
        /// <returns>Returns nullable ActivityType enum representing the ActivityType field</returns>
        public ActivityType? GetActivityType(int index)
        {
            object obj = GetFieldValue(1, index, Fit.SubfieldIndexMainField);
            ActivityType? value = obj == null ? (ActivityType?)null : (ActivityType)obj;
            return value;
        }

        /// <summary>
        /// Set ActivityType field</summary>
        /// <param name="index">0 based index of activity_type</param>
        /// <param name="activityType_">Nullable field value to be set</param>
        public void SetActivityType(int index, ActivityType? activityType_)
        {
            SetFieldValue(1, index, activityType_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CyclesToDistance</returns>
        public int GetNumCyclesToDistance()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CyclesToDistance field
        /// Units: m/cycle
        /// Comment: Indexed by activity_type</summary>
        /// <param name="index">0 based index of CyclesToDistance element to retrieve</param>
        /// <returns>Returns nullable float representing the CyclesToDistance field</returns>
        public float? GetCyclesToDistance(int index)
        {
            Object val = GetFieldValue(3, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CyclesToDistance field
        /// Units: m/cycle
        /// Comment: Indexed by activity_type</summary>
        /// <param name="index">0 based index of cycles_to_distance</param>
        /// <param name="cyclesToDistance_">Nullable field value to be set</param>
        public void SetCyclesToDistance(int index, float? cyclesToDistance_)
        {
            SetFieldValue(3, index, cyclesToDistance_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CyclesToCalories</returns>
        public int GetNumCyclesToCalories()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CyclesToCalories field
        /// Units: kcal/cycle
        /// Comment: Indexed by activity_type</summary>
        /// <param name="index">0 based index of CyclesToCalories element to retrieve</param>
        /// <returns>Returns nullable float representing the CyclesToCalories field</returns>
        public float? GetCyclesToCalories(int index)
        {
            Object val = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CyclesToCalories field
        /// Units: kcal/cycle
        /// Comment: Indexed by activity_type</summary>
        /// <param name="index">0 based index of cycles_to_calories</param>
        /// <param name="cyclesToCalories_">Nullable field value to be set</param>
        public void SetCyclesToCalories(int index, float? cyclesToCalories_)
        {
            SetFieldValue(4, index, cyclesToCalories_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the RestingMetabolicRate field
        /// Units: kcal / day</summary>
        /// <returns>Returns nullable ushort representing the RestingMetabolicRate field</returns>
        public ushort? GetRestingMetabolicRate()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set RestingMetabolicRate field
        /// Units: kcal / day</summary>
        /// <param name="restingMetabolicRate_">Nullable field value to be set</param>
        public void SetRestingMetabolicRate(ushort? restingMetabolicRate_)
        {
            SetFieldValue(5, 0, restingMetabolicRate_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

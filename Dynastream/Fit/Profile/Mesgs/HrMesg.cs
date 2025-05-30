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
    /// Implements the Hr profile message.
    /// </summary>
    public class HrMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="HrMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte FractionalTimestamp = 0;
            public const byte Time256 = 1;
            public const byte FilteredBpm = 6;
            public const byte EventTimestamp = 9;
            public const byte EventTimestamp12 = 10;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public HrMesg() : base(Profile.GetMesg(MesgNum.Hr))
        {
        }

        public HrMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field</summary>
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
        /// Set Timestamp field</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FractionalTimestamp field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the FractionalTimestamp field</returns>
        public float? GetFractionalTimestamp()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set FractionalTimestamp field
        /// Units: s</summary>
        /// <param name="fractionalTimestamp_">Nullable field value to be set</param>
        public void SetFractionalTimestamp(float? fractionalTimestamp_)
        {
            SetFieldValue(0, 0, fractionalTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Time256 field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the Time256 field</returns>
        public float? GetTime256()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Time256 field
        /// Units: s</summary>
        /// <param name="time256_">Nullable field value to be set</param>
        public void SetTime256(float? time256_)
        {
            SetFieldValue(1, 0, time256_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field FilteredBpm</returns>
        public int GetNumFilteredBpm()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the FilteredBpm field
        /// Units: bpm</summary>
        /// <param name="index">0 based index of FilteredBpm element to retrieve</param>
        /// <returns>Returns nullable byte representing the FilteredBpm field</returns>
        public byte? GetFilteredBpm(int index)
        {
            Object val = GetFieldValue(6, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set FilteredBpm field
        /// Units: bpm</summary>
        /// <param name="index">0 based index of filtered_bpm</param>
        /// <param name="filteredBpm_">Nullable field value to be set</param>
        public void SetFilteredBpm(int index, byte? filteredBpm_)
        {
            SetFieldValue(6, index, filteredBpm_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field EventTimestamp</returns>
        public int GetNumEventTimestamp()
        {
            return GetNumFieldValues(9, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the EventTimestamp field
        /// Units: s</summary>
        /// <param name="index">0 based index of EventTimestamp element to retrieve</param>
        /// <returns>Returns nullable float representing the EventTimestamp field</returns>
        public float? GetEventTimestamp(int index)
        {
            Object val = GetFieldValue(9, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set EventTimestamp field
        /// Units: s</summary>
        /// <param name="index">0 based index of event_timestamp</param>
        /// <param name="eventTimestamp_">Nullable field value to be set</param>
        public void SetEventTimestamp(int index, float? eventTimestamp_)
        {
            SetFieldValue(9, index, eventTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field EventTimestamp12</returns>
        public int GetNumEventTimestamp12()
        {
            return GetNumFieldValues(10, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the EventTimestamp12 field</summary>
        /// <param name="index">0 based index of EventTimestamp12 element to retrieve</param>
        /// <returns>Returns nullable byte representing the EventTimestamp12 field</returns>
        public byte? GetEventTimestamp12(int index)
        {
            Object val = GetFieldValue(10, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set EventTimestamp12 field</summary>
        /// <param name="index">0 based index of event_timestamp_12</param>
        /// <param name="eventTimestamp12_">Nullable field value to be set</param>
        public void SetEventTimestamp12(int index, byte? eventTimestamp12_)
        {
            SetFieldValue(10, index, eventTimestamp12_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

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
    /// Implements the RawBbi profile message.
    /// </summary>
    public class RawBbiMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="RawBbiMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte TimestampMs = 0;
            public const byte Data = 1;
            public const byte Time = 2;
            public const byte Quality = 3;
            public const byte Gap = 4;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public RawBbiMesg() : base(Profile.GetMesg(MesgNum.RawBbi))
        {
        }

        public RawBbiMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Millisecond resolution of the timestamp</summary>
        /// <returns>Returns nullable ushort representing the TimestampMs field</returns>
        public ushort? GetTimestampMs()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set TimestampMs field
        /// Units: ms
        /// Comment: Millisecond resolution of the timestamp</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(0, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Data</returns>
        public int GetNumData()
        {
            return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Data field
        /// Comment: 1 bit for gap indicator, 1 bit for quality indicator, and 14 bits for Beat-to-Beat interval values in whole-integer millisecond resolution</summary>
        /// <param name="index">0 based index of Data element to retrieve</param>
        /// <returns>Returns nullable ushort representing the Data field</returns>
        public ushort? GetData(int index)
        {
            Object val = GetFieldValue(1, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Data field
        /// Comment: 1 bit for gap indicator, 1 bit for quality indicator, and 14 bits for Beat-to-Beat interval values in whole-integer millisecond resolution</summary>
        /// <param name="index">0 based index of data</param>
        /// <param name="data_">Nullable field value to be set</param>
        public void SetData(int index, ushort? data_)
        {
            SetFieldValue(1, index, data_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Time</returns>
        public int GetNumTime()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Time field
        /// Units: ms
        /// Comment: Array of millisecond times between beats</summary>
        /// <param name="index">0 based index of Time element to retrieve</param>
        /// <returns>Returns nullable ushort representing the Time field</returns>
        public ushort? GetTime(int index)
        {
            Object val = GetFieldValue(2, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Time field
        /// Units: ms
        /// Comment: Array of millisecond times between beats</summary>
        /// <param name="index">0 based index of time</param>
        /// <param name="time_">Nullable field value to be set</param>
        public void SetTime(int index, ushort? time_)
        {
            SetFieldValue(2, index, time_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Quality</returns>
        public int GetNumQuality()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Quality field
        /// Comment: 1 = high confidence. 0 = low confidence. N/A when gap = 1</summary>
        /// <param name="index">0 based index of Quality element to retrieve</param>
        /// <returns>Returns nullable byte representing the Quality field</returns>
        public byte? GetQuality(int index)
        {
            Object val = GetFieldValue(3, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Quality field
        /// Comment: 1 = high confidence. 0 = low confidence. N/A when gap = 1</summary>
        /// <param name="index">0 based index of quality</param>
        /// <param name="quality_">Nullable field value to be set</param>
        public void SetQuality(int index, byte? quality_)
        {
            SetFieldValue(3, index, quality_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Gap</returns>
        public int GetNumGap()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Gap field
        /// Comment: 1 = gap (time represents ms gap length). 0 = BBI data</summary>
        /// <param name="index">0 based index of Gap element to retrieve</param>
        /// <returns>Returns nullable byte representing the Gap field</returns>
        public byte? GetGap(int index)
        {
            Object val = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set Gap field
        /// Comment: 1 = gap (time represents ms gap length). 0 = BBI data</summary>
        /// <param name="index">0 based index of gap</param>
        /// <param name="gap_">Nullable field value to be set</param>
        public void SetGap(int index, byte? gap_)
        {
            SetFieldValue(4, index, gap_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

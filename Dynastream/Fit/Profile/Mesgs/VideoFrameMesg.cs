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
    /// Implements the VideoFrame profile message.
    /// </summary>
    public class VideoFrameMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="VideoFrameMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte TimestampMs = 0;
            public const byte FrameNumber = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public VideoFrameMesg() : base(Profile.GetMesg(MesgNum.VideoFrame))
        {
        }

        public VideoFrameMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Whole second part of the timestamp</summary>
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
        /// Units: s
        /// Comment: Whole second part of the timestamp</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the timestamp.</summary>
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
        /// Comment: Millisecond part of the timestamp.</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(0, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FrameNumber field
        /// Comment: Number of the frame that the timestamp and timestamp_ms correlate to</summary>
        /// <returns>Returns nullable uint representing the FrameNumber field</returns>
        public uint? GetFrameNumber()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set FrameNumber field
        /// Comment: Number of the frame that the timestamp and timestamp_ms correlate to</summary>
        /// <param name="frameNumber_">Nullable field value to be set</param>
        public void SetFrameNumber(uint? frameNumber_)
        {
            SetFieldValue(1, 0, frameNumber_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

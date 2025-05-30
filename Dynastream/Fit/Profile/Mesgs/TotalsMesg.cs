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
    /// Implements the Totals profile message.
    /// </summary>
    public class TotalsMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="TotalsMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Timestamp = 253;
            public const byte TimerTime = 0;
            public const byte Distance = 1;
            public const byte Calories = 2;
            public const byte Sport = 3;
            public const byte ElapsedTime = 4;
            public const byte Sessions = 5;
            public const byte ActiveTime = 6;
            public const byte SportIndex = 9;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public TotalsMesg() : base(Profile.GetMesg(MesgNum.Totals))
        {
        }

        public TotalsMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the TimerTime field
        /// Units: s
        /// Comment: Excludes pauses</summary>
        /// <returns>Returns nullable uint representing the TimerTime field</returns>
        public uint? GetTimerTime()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set TimerTime field
        /// Units: s
        /// Comment: Excludes pauses</summary>
        /// <param name="timerTime_">Nullable field value to be set</param>
        public void SetTimerTime(uint? timerTime_)
        {
            SetFieldValue(0, 0, timerTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Distance field
        /// Units: m</summary>
        /// <returns>Returns nullable uint representing the Distance field</returns>
        public uint? GetDistance()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Distance field
        /// Units: m</summary>
        /// <param name="distance_">Nullable field value to be set</param>
        public void SetDistance(uint? distance_)
        {
            SetFieldValue(1, 0, distance_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Calories field
        /// Units: kcal</summary>
        /// <returns>Returns nullable uint representing the Calories field</returns>
        public uint? GetCalories()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Calories field
        /// Units: kcal</summary>
        /// <param name="calories_">Nullable field value to be set</param>
        public void SetCalories(uint? calories_)
        {
            SetFieldValue(2, 0, calories_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>
        public Sport? GetSport()
        {
            object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            Sport? value = obj == null ? (Sport?)null : (Sport)obj;
            return value;
        }

        /// <summary>
        /// Set Sport field</summary>
        /// <param name="sport_">Nullable field value to be set</param>
        public void SetSport(Sport? sport_)
        {
            SetFieldValue(3, 0, sport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ElapsedTime field
        /// Units: s
        /// Comment: Includes pauses</summary>
        /// <returns>Returns nullable uint representing the ElapsedTime field</returns>
        public uint? GetElapsedTime()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set ElapsedTime field
        /// Units: s
        /// Comment: Includes pauses</summary>
        /// <param name="elapsedTime_">Nullable field value to be set</param>
        public void SetElapsedTime(uint? elapsedTime_)
        {
            SetFieldValue(4, 0, elapsedTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sessions field</summary>
        /// <returns>Returns nullable ushort representing the Sessions field</returns>
        public ushort? GetSessions()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Sessions field</summary>
        /// <param name="sessions_">Nullable field value to be set</param>
        public void SetSessions(ushort? sessions_)
        {
            SetFieldValue(5, 0, sessions_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActiveTime field
        /// Units: s</summary>
        /// <returns>Returns nullable uint representing the ActiveTime field</returns>
        public uint? GetActiveTime()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set ActiveTime field
        /// Units: s</summary>
        /// <param name="activeTime_">Nullable field value to be set</param>
        public void SetActiveTime(uint? activeTime_)
        {
            SetFieldValue(6, 0, activeTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SportIndex field</summary>
        /// <returns>Returns nullable byte representing the SportIndex field</returns>
        public byte? GetSportIndex()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set SportIndex field</summary>
        /// <param name="sportIndex_">Nullable field value to be set</param>
        public void SetSportIndex(byte? sportIndex_)
        {
            SetFieldValue(9, 0, sportIndex_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.133.0Release
// Tag = production/release/21.133.0-0-g6002091
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
    /// Implements the DiveApneaAlarm profile message.
    /// </summary>
    public class DiveApneaAlarmMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="DiveApneaAlarmMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Depth = 0;
            public const byte Time = 1;
            public const byte Enabled = 2;
            public const byte AlarmType = 3;
            public const byte Sound = 4;
            public const byte DiveTypes = 5;
            public const byte Id = 6;
            public const byte PopupEnabled = 7;
            public const byte TriggerOnDescent = 8;
            public const byte TriggerOnAscent = 9;
            public const byte Repeating = 10;
            public const byte Speed = 11;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public DiveApneaAlarmMesg() : base(Profile.GetMesg(MesgNum.DiveApneaAlarm))
        {
        }

        public DiveApneaAlarmMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field
        /// Comment: Index of the alarm</summary>
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
        /// Set MessageIndex field
        /// Comment: Index of the alarm</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Depth field
        /// Units: m
        /// Comment: Depth setting (m) for depth type alarms</summary>
        /// <returns>Returns nullable float representing the Depth field</returns>
        public float? GetDepth()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Depth field
        /// Units: m
        /// Comment: Depth setting (m) for depth type alarms</summary>
        /// <param name="depth_">Nullable field value to be set</param>
        public void SetDepth(float? depth_)
        {
            SetFieldValue(0, 0, depth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Time field
        /// Units: s
        /// Comment: Time setting (s) for time type alarms</summary>
        /// <returns>Returns nullable int representing the Time field</returns>
        public int? GetTime()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt32(val));
            
        }

        /// <summary>
        /// Set Time field
        /// Units: s
        /// Comment: Time setting (s) for time type alarms</summary>
        /// <param name="time_">Nullable field value to be set</param>
        public void SetTime(int? time_)
        {
            SetFieldValue(1, 0, time_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Enabled field
        /// Comment: Enablement flag</summary>
        /// <returns>Returns nullable Bool enum representing the Enabled field</returns>
        public Bool? GetEnabled()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Enabled field
        /// Comment: Enablement flag</summary>
        /// <param name="enabled_">Nullable field value to be set</param>
        public void SetEnabled(Bool? enabled_)
        {
            SetFieldValue(2, 0, enabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AlarmType field
        /// Comment: Alarm type setting</summary>
        /// <returns>Returns nullable DiveAlarmType enum representing the AlarmType field</returns>
        public DiveAlarmType? GetAlarmType()
        {
            object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            DiveAlarmType? value = obj == null ? (DiveAlarmType?)null : (DiveAlarmType)obj;
            return value;
        }

        /// <summary>
        /// Set AlarmType field
        /// Comment: Alarm type setting</summary>
        /// <param name="alarmType_">Nullable field value to be set</param>
        public void SetAlarmType(DiveAlarmType? alarmType_)
        {
            SetFieldValue(3, 0, alarmType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sound field
        /// Comment: Tone and Vibe setting for the alarm.</summary>
        /// <returns>Returns nullable Tone enum representing the Sound field</returns>
        public Tone? GetSound()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            Tone? value = obj == null ? (Tone?)null : (Tone)obj;
            return value;
        }

        /// <summary>
        /// Set Sound field
        /// Comment: Tone and Vibe setting for the alarm.</summary>
        /// <param name="sound_">Nullable field value to be set</param>
        public void SetSound(Tone? sound_)
        {
            SetFieldValue(4, 0, sound_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field DiveTypes</returns>
        public int GetNumDiveTypes()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the DiveTypes field
        /// Comment: Dive types the alarm will trigger on</summary>
        /// <param name="index">0 based index of DiveTypes element to retrieve</param>
        /// <returns>Returns nullable SubSport enum representing the DiveTypes field</returns>
        public SubSport? GetDiveTypes(int index)
        {
            object obj = GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set DiveTypes field
        /// Comment: Dive types the alarm will trigger on</summary>
        /// <param name="index">0 based index of dive_types</param>
        /// <param name="diveTypes_">Nullable field value to be set</param>
        public void SetDiveTypes(int index, SubSport? diveTypes_)
        {
            SetFieldValue(5, index, diveTypes_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Id field
        /// Comment: Alarm ID</summary>
        /// <returns>Returns nullable uint representing the Id field</returns>
        public uint? GetId()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Id field
        /// Comment: Alarm ID</summary>
        /// <param name="id_">Nullable field value to be set</param>
        public void SetId(uint? id_)
        {
            SetFieldValue(6, 0, id_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PopupEnabled field
        /// Comment: Show a visible pop-up for this alarm</summary>
        /// <returns>Returns nullable Bool enum representing the PopupEnabled field</returns>
        public Bool? GetPopupEnabled()
        {
            object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set PopupEnabled field
        /// Comment: Show a visible pop-up for this alarm</summary>
        /// <param name="popupEnabled_">Nullable field value to be set</param>
        public void SetPopupEnabled(Bool? popupEnabled_)
        {
            SetFieldValue(7, 0, popupEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TriggerOnDescent field
        /// Comment: Trigger the alarm on descent</summary>
        /// <returns>Returns nullable Bool enum representing the TriggerOnDescent field</returns>
        public Bool? GetTriggerOnDescent()
        {
            object obj = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set TriggerOnDescent field
        /// Comment: Trigger the alarm on descent</summary>
        /// <param name="triggerOnDescent_">Nullable field value to be set</param>
        public void SetTriggerOnDescent(Bool? triggerOnDescent_)
        {
            SetFieldValue(8, 0, triggerOnDescent_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TriggerOnAscent field
        /// Comment: Trigger the alarm on ascent</summary>
        /// <returns>Returns nullable Bool enum representing the TriggerOnAscent field</returns>
        public Bool? GetTriggerOnAscent()
        {
            object obj = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set TriggerOnAscent field
        /// Comment: Trigger the alarm on ascent</summary>
        /// <param name="triggerOnAscent_">Nullable field value to be set</param>
        public void SetTriggerOnAscent(Bool? triggerOnAscent_)
        {
            SetFieldValue(9, 0, triggerOnAscent_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Repeating field
        /// Comment: Repeat alarm each time threshold is crossed?</summary>
        /// <returns>Returns nullable Bool enum representing the Repeating field</returns>
        public Bool? GetRepeating()
        {
            object obj = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Repeating field
        /// Comment: Repeat alarm each time threshold is crossed?</summary>
        /// <param name="repeating_">Nullable field value to be set</param>
        public void SetRepeating(Bool? repeating_)
        {
            SetFieldValue(10, 0, repeating_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Speed field
        /// Units: mps
        /// Comment: Ascent/descent rate (mps) setting for speed type alarms</summary>
        /// <returns>Returns nullable float representing the Speed field</returns>
        public float? GetSpeed()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Speed field
        /// Units: mps
        /// Comment: Ascent/descent rate (mps) setting for speed type alarms</summary>
        /// <param name="speed_">Nullable field value to be set</param>
        public void SetSpeed(float? speed_)
        {
            SetFieldValue(11, 0, speed_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

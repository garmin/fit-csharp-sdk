#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.120Release
// Tag = production/release/21.120.00-0-g2d77811
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
    /// Implements the TankUpdate profile message.
    /// </summary>
    public class TankUpdateMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="TankUpdateMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte Sensor = 0;
            public const byte Pressure = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public TankUpdateMesg() : base(Profile.GetMesg(MesgNum.TankUpdate))
        {
        }

        public TankUpdateMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the Sensor field</summary>
        /// <returns>Returns nullable uint representing the Sensor field</returns>
        public uint? GetSensor()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Sensor field</summary>
        /// <param name="sensor_">Nullable field value to be set</param>
        public void SetSensor(uint? sensor_)
        {
            SetFieldValue(0, 0, sensor_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Pressure field
        /// Units: bar</summary>
        /// <returns>Returns nullable float representing the Pressure field</returns>
        public float? GetPressure()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Pressure field
        /// Units: bar</summary>
        /// <param name="pressure_">Nullable field value to be set</param>
        public void SetPressure(float? pressure_)
        {
            SetFieldValue(1, 0, pressure_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

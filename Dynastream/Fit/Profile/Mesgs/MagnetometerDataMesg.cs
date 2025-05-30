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
    /// Implements the MagnetometerData profile message.
    /// </summary>
    public class MagnetometerDataMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MagnetometerDataMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte TimestampMs = 0;
            public const byte SampleTimeOffset = 1;
            public const byte MagX = 2;
            public const byte MagY = 3;
            public const byte MagZ = 4;
            public const byte CalibratedMagX = 5;
            public const byte CalibratedMagY = 6;
            public const byte CalibratedMagZ = 7;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MagnetometerDataMesg() : base(Profile.GetMesg(MesgNum.MagnetometerData))
        {
        }

        public MagnetometerDataMesg(Mesg mesg) : base(mesg)
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
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field SampleTimeOffset</returns>
        public int GetNumSampleTimeOffset()
        {
            return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the SampleTimeOffset field
        /// Units: ms
        /// Comment: Each time in the array describes the time at which the compass sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in cmps_x and cmps_y and cmps_z</summary>
        /// <param name="index">0 based index of SampleTimeOffset element to retrieve</param>
        /// <returns>Returns nullable ushort representing the SampleTimeOffset field</returns>
        public ushort? GetSampleTimeOffset(int index)
        {
            Object val = GetFieldValue(1, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set SampleTimeOffset field
        /// Units: ms
        /// Comment: Each time in the array describes the time at which the compass sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in cmps_x and cmps_y and cmps_z</summary>
        /// <param name="index">0 based index of sample_time_offset</param>
        /// <param name="sampleTimeOffset_">Nullable field value to be set</param>
        public void SetSampleTimeOffset(int index, ushort? sampleTimeOffset_)
        {
            SetFieldValue(1, index, sampleTimeOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field MagX</returns>
        public int GetNumMagX()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the MagX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of MagX element to retrieve</param>
        /// <returns>Returns nullable ushort representing the MagX field</returns>
        public ushort? GetMagX(int index)
        {
            Object val = GetFieldValue(2, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MagX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of mag_x</param>
        /// <param name="magX_">Nullable field value to be set</param>
        public void SetMagX(int index, ushort? magX_)
        {
            SetFieldValue(2, index, magX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field MagY</returns>
        public int GetNumMagY()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the MagY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of MagY element to retrieve</param>
        /// <returns>Returns nullable ushort representing the MagY field</returns>
        public ushort? GetMagY(int index)
        {
            Object val = GetFieldValue(3, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MagY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of mag_y</param>
        /// <param name="magY_">Nullable field value to be set</param>
        public void SetMagY(int index, ushort? magY_)
        {
            SetFieldValue(3, index, magY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field MagZ</returns>
        public int GetNumMagZ()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the MagZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of MagZ element to retrieve</param>
        /// <returns>Returns nullable ushort representing the MagZ field</returns>
        public ushort? GetMagZ(int index)
        {
            Object val = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MagZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of mag_z</param>
        /// <param name="magZ_">Nullable field value to be set</param>
        public void SetMagZ(int index, ushort? magZ_)
        {
            SetFieldValue(4, index, magZ_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedMagX</returns>
        public int GetNumCalibratedMagX()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedMagX field
        /// Units: G
        /// Comment: Calibrated Magnetometer reading</summary>
        /// <param name="index">0 based index of CalibratedMagX element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedMagX field</returns>
        public float? GetCalibratedMagX(int index)
        {
            Object val = GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CalibratedMagX field
        /// Units: G
        /// Comment: Calibrated Magnetometer reading</summary>
        /// <param name="index">0 based index of calibrated_mag_x</param>
        /// <param name="calibratedMagX_">Nullable field value to be set</param>
        public void SetCalibratedMagX(int index, float? calibratedMagX_)
        {
            SetFieldValue(5, index, calibratedMagX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedMagY</returns>
        public int GetNumCalibratedMagY()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedMagY field
        /// Units: G
        /// Comment: Calibrated Magnetometer reading</summary>
        /// <param name="index">0 based index of CalibratedMagY element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedMagY field</returns>
        public float? GetCalibratedMagY(int index)
        {
            Object val = GetFieldValue(6, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CalibratedMagY field
        /// Units: G
        /// Comment: Calibrated Magnetometer reading</summary>
        /// <param name="index">0 based index of calibrated_mag_y</param>
        /// <param name="calibratedMagY_">Nullable field value to be set</param>
        public void SetCalibratedMagY(int index, float? calibratedMagY_)
        {
            SetFieldValue(6, index, calibratedMagY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedMagZ</returns>
        public int GetNumCalibratedMagZ()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedMagZ field
        /// Units: G
        /// Comment: Calibrated Magnetometer reading</summary>
        /// <param name="index">0 based index of CalibratedMagZ element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedMagZ field</returns>
        public float? GetCalibratedMagZ(int index)
        {
            Object val = GetFieldValue(7, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CalibratedMagZ field
        /// Units: G
        /// Comment: Calibrated Magnetometer reading</summary>
        /// <param name="index">0 based index of calibrated_mag_z</param>
        /// <param name="calibratedMagZ_">Nullable field value to be set</param>
        public void SetCalibratedMagZ(int index, float? calibratedMagZ_)
        {
            SetFieldValue(7, index, calibratedMagZ_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

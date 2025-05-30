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
    /// Implements the AccelerometerData profile message.
    /// </summary>
    public class AccelerometerDataMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="AccelerometerDataMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte TimestampMs = 0;
            public const byte SampleTimeOffset = 1;
            public const byte AccelX = 2;
            public const byte AccelY = 3;
            public const byte AccelZ = 4;
            public const byte CalibratedAccelX = 5;
            public const byte CalibratedAccelY = 6;
            public const byte CalibratedAccelZ = 7;
            public const byte CompressedCalibratedAccelX = 8;
            public const byte CompressedCalibratedAccelY = 9;
            public const byte CompressedCalibratedAccelZ = 10;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public AccelerometerDataMesg() : base(Profile.GetMesg(MesgNum.AccelerometerData))
        {
        }

        public AccelerometerDataMesg(Mesg mesg) : base(mesg)
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
        /// Comment: Each time in the array describes the time at which the accelerometer sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in accel_x and accel_y and accel_z</summary>
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
        /// Comment: Each time in the array describes the time at which the accelerometer sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in accel_x and accel_y and accel_z</summary>
        /// <param name="index">0 based index of sample_time_offset</param>
        /// <param name="sampleTimeOffset_">Nullable field value to be set</param>
        public void SetSampleTimeOffset(int index, ushort? sampleTimeOffset_)
        {
            SetFieldValue(1, index, sampleTimeOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelX</returns>
        public int GetNumAccelX()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of AccelX element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AccelX field</returns>
        public ushort? GetAccelX(int index)
        {
            Object val = GetFieldValue(2, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set AccelX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of accel_x</param>
        /// <param name="accelX_">Nullable field value to be set</param>
        public void SetAccelX(int index, ushort? accelX_)
        {
            SetFieldValue(2, index, accelX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelY</returns>
        public int GetNumAccelY()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of AccelY element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AccelY field</returns>
        public ushort? GetAccelY(int index)
        {
            Object val = GetFieldValue(3, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set AccelY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of accel_y</param>
        /// <param name="accelY_">Nullable field value to be set</param>
        public void SetAccelY(int index, ushort? accelY_)
        {
            SetFieldValue(3, index, accelY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelZ</returns>
        public int GetNumAccelZ()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of AccelZ element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AccelZ field</returns>
        public ushort? GetAccelZ(int index)
        {
            Object val = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set AccelZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of accel_z</param>
        /// <param name="accelZ_">Nullable field value to be set</param>
        public void SetAccelZ(int index, ushort? accelZ_)
        {
            SetFieldValue(4, index, accelZ_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedAccelX</returns>
        public int GetNumCalibratedAccelX()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedAccelX field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CalibratedAccelX element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedAccelX field</returns>
        public float? GetCalibratedAccelX(int index)
        {
            Object val = GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CalibratedAccelX field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of calibrated_accel_x</param>
        /// <param name="calibratedAccelX_">Nullable field value to be set</param>
        public void SetCalibratedAccelX(int index, float? calibratedAccelX_)
        {
            SetFieldValue(5, index, calibratedAccelX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedAccelY</returns>
        public int GetNumCalibratedAccelY()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedAccelY field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CalibratedAccelY element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedAccelY field</returns>
        public float? GetCalibratedAccelY(int index)
        {
            Object val = GetFieldValue(6, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CalibratedAccelY field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of calibrated_accel_y</param>
        /// <param name="calibratedAccelY_">Nullable field value to be set</param>
        public void SetCalibratedAccelY(int index, float? calibratedAccelY_)
        {
            SetFieldValue(6, index, calibratedAccelY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedAccelZ</returns>
        public int GetNumCalibratedAccelZ()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedAccelZ field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CalibratedAccelZ element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedAccelZ field</returns>
        public float? GetCalibratedAccelZ(int index)
        {
            Object val = GetFieldValue(7, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CalibratedAccelZ field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of calibrated_accel_z</param>
        /// <param name="calibratedAccelZ_">Nullable field value to be set</param>
        public void SetCalibratedAccelZ(int index, float? calibratedAccelZ_)
        {
            SetFieldValue(7, index, calibratedAccelZ_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CompressedCalibratedAccelX</returns>
        public int GetNumCompressedCalibratedAccelX()
        {
            return GetNumFieldValues(8, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CompressedCalibratedAccelX field
        /// Units: mG
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CompressedCalibratedAccelX element to retrieve</param>
        /// <returns>Returns nullable short representing the CompressedCalibratedAccelX field</returns>
        public short? GetCompressedCalibratedAccelX(int index)
        {
            Object val = GetFieldValue(8, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt16(val));
            
        }

        /// <summary>
        /// Set CompressedCalibratedAccelX field
        /// Units: mG
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of compressed_calibrated_accel_x</param>
        /// <param name="compressedCalibratedAccelX_">Nullable field value to be set</param>
        public void SetCompressedCalibratedAccelX(int index, short? compressedCalibratedAccelX_)
        {
            SetFieldValue(8, index, compressedCalibratedAccelX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CompressedCalibratedAccelY</returns>
        public int GetNumCompressedCalibratedAccelY()
        {
            return GetNumFieldValues(9, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CompressedCalibratedAccelY field
        /// Units: mG
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CompressedCalibratedAccelY element to retrieve</param>
        /// <returns>Returns nullable short representing the CompressedCalibratedAccelY field</returns>
        public short? GetCompressedCalibratedAccelY(int index)
        {
            Object val = GetFieldValue(9, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt16(val));
            
        }

        /// <summary>
        /// Set CompressedCalibratedAccelY field
        /// Units: mG
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of compressed_calibrated_accel_y</param>
        /// <param name="compressedCalibratedAccelY_">Nullable field value to be set</param>
        public void SetCompressedCalibratedAccelY(int index, short? compressedCalibratedAccelY_)
        {
            SetFieldValue(9, index, compressedCalibratedAccelY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CompressedCalibratedAccelZ</returns>
        public int GetNumCompressedCalibratedAccelZ()
        {
            return GetNumFieldValues(10, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CompressedCalibratedAccelZ field
        /// Units: mG
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CompressedCalibratedAccelZ element to retrieve</param>
        /// <returns>Returns nullable short representing the CompressedCalibratedAccelZ field</returns>
        public short? GetCompressedCalibratedAccelZ(int index)
        {
            Object val = GetFieldValue(10, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt16(val));
            
        }

        /// <summary>
        /// Set CompressedCalibratedAccelZ field
        /// Units: mG
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of compressed_calibrated_accel_z</param>
        /// <param name="compressedCalibratedAccelZ_">Nullable field value to be set</param>
        public void SetCompressedCalibratedAccelZ(int index, short? compressedCalibratedAccelZ_)
        {
            SetFieldValue(10, index, compressedCalibratedAccelZ_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

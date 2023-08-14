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
    /// Implements the DiveSettings profile message.
    /// </summary>
    public class DiveSettingsMesg : Mesg
    {
        #region Fields
        static class HeartRateSourceSubfield
        {
            public static ushort HeartRateAntplusDeviceType = 0;
            public static ushort HeartRateLocalDeviceType = 1;
            public static ushort Subfields = 2;
            public static ushort Active = Fit.SubfieldIndexActiveSubfield;
            public static ushort MainField = Fit.SubfieldIndexMainField;
        }
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="DiveSettingsMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte MessageIndex = 254;
            public const byte Name = 0;
            public const byte Model = 1;
            public const byte GfLow = 2;
            public const byte GfHigh = 3;
            public const byte WaterType = 4;
            public const byte WaterDensity = 5;
            public const byte Po2Warn = 6;
            public const byte Po2Critical = 7;
            public const byte Po2Deco = 8;
            public const byte SafetyStopEnabled = 9;
            public const byte BottomDepth = 10;
            public const byte BottomTime = 11;
            public const byte ApneaCountdownEnabled = 12;
            public const byte ApneaCountdownTime = 13;
            public const byte BacklightMode = 14;
            public const byte BacklightBrightness = 15;
            public const byte BacklightTimeout = 16;
            public const byte RepeatDiveInterval = 17;
            public const byte SafetyStopTime = 18;
            public const byte HeartRateSourceType = 19;
            public const byte HeartRateSource = 20;
            public const byte TravelGas = 21;
            public const byte CcrLowSetpointSwitchMode = 22;
            public const byte CcrLowSetpoint = 23;
            public const byte CcrLowSetpointDepth = 24;
            public const byte CcrHighSetpointSwitchMode = 25;
            public const byte CcrHighSetpoint = 26;
            public const byte CcrHighSetpointDepth = 27;
            public const byte GasConsumptionDisplay = 29;
            public const byte UpKeyEnabled = 30;
            public const byte DiveSounds = 35;
            public const byte LastStopMultiple = 36;
            public const byte NoFlyTimeMode = 37;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public DiveSettingsMesg() : base(Profile.GetMesg(MesgNum.DiveSettings))
        {
        }

        public DiveSettingsMesg(Mesg mesg) : base(mesg)
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
        /// Retrieves the Name field</summary>
        /// <returns>Returns byte[] representing the Name field</returns>
        public byte[] GetName()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns String representing the Name field</returns>
        public String GetNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Name field</summary>
        /// <param name="name_"> field value to be set</param>
        public void SetName(String name_)
        {
            byte[] data = Encoding.UTF8.GetBytes(name_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(0, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Name field</summary>
        /// <param name="name_">field value to be set</param>
        public void SetName(byte[] name_)
        {
            SetFieldValue(0, 0, name_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Model field</summary>
        /// <returns>Returns nullable TissueModelType enum representing the Model field</returns>
        public TissueModelType? GetModel()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            TissueModelType? value = obj == null ? (TissueModelType?)null : (TissueModelType)obj;
            return value;
        }

        /// <summary>
        /// Set Model field</summary>
        /// <param name="model_">Nullable field value to be set</param>
        public void SetModel(TissueModelType? model_)
        {
            SetFieldValue(1, 0, model_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the GfLow field
        /// Units: percent</summary>
        /// <returns>Returns nullable byte representing the GfLow field</returns>
        public byte? GetGfLow()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set GfLow field
        /// Units: percent</summary>
        /// <param name="gfLow_">Nullable field value to be set</param>
        public void SetGfLow(byte? gfLow_)
        {
            SetFieldValue(2, 0, gfLow_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the GfHigh field
        /// Units: percent</summary>
        /// <returns>Returns nullable byte representing the GfHigh field</returns>
        public byte? GetGfHigh()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set GfHigh field
        /// Units: percent</summary>
        /// <param name="gfHigh_">Nullable field value to be set</param>
        public void SetGfHigh(byte? gfHigh_)
        {
            SetFieldValue(3, 0, gfHigh_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WaterType field</summary>
        /// <returns>Returns nullable WaterType enum representing the WaterType field</returns>
        public WaterType? GetWaterType()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            WaterType? value = obj == null ? (WaterType?)null : (WaterType)obj;
            return value;
        }

        /// <summary>
        /// Set WaterType field</summary>
        /// <param name="waterType_">Nullable field value to be set</param>
        public void SetWaterType(WaterType? waterType_)
        {
            SetFieldValue(4, 0, waterType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the WaterDensity field
        /// Units: kg/m^3
        /// Comment: Fresh water is usually 1000; salt water is usually 1025</summary>
        /// <returns>Returns nullable float representing the WaterDensity field</returns>
        public float? GetWaterDensity()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set WaterDensity field
        /// Units: kg/m^3
        /// Comment: Fresh water is usually 1000; salt water is usually 1025</summary>
        /// <param name="waterDensity_">Nullable field value to be set</param>
        public void SetWaterDensity(float? waterDensity_)
        {
            SetFieldValue(5, 0, waterDensity_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Po2Warn field
        /// Units: percent
        /// Comment: Typically 1.40</summary>
        /// <returns>Returns nullable float representing the Po2Warn field</returns>
        public float? GetPo2Warn()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Po2Warn field
        /// Units: percent
        /// Comment: Typically 1.40</summary>
        /// <param name="po2Warn_">Nullable field value to be set</param>
        public void SetPo2Warn(float? po2Warn_)
        {
            SetFieldValue(6, 0, po2Warn_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Po2Critical field
        /// Units: percent
        /// Comment: Typically 1.60</summary>
        /// <returns>Returns nullable float representing the Po2Critical field</returns>
        public float? GetPo2Critical()
        {
            Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Po2Critical field
        /// Units: percent
        /// Comment: Typically 1.60</summary>
        /// <param name="po2Critical_">Nullable field value to be set</param>
        public void SetPo2Critical(float? po2Critical_)
        {
            SetFieldValue(7, 0, po2Critical_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Po2Deco field
        /// Units: percent</summary>
        /// <returns>Returns nullable float representing the Po2Deco field</returns>
        public float? GetPo2Deco()
        {
            Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Po2Deco field
        /// Units: percent</summary>
        /// <param name="po2Deco_">Nullable field value to be set</param>
        public void SetPo2Deco(float? po2Deco_)
        {
            SetFieldValue(8, 0, po2Deco_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SafetyStopEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the SafetyStopEnabled field</returns>
        public Bool? GetSafetyStopEnabled()
        {
            object obj = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set SafetyStopEnabled field</summary>
        /// <param name="safetyStopEnabled_">Nullable field value to be set</param>
        public void SetSafetyStopEnabled(Bool? safetyStopEnabled_)
        {
            SetFieldValue(9, 0, safetyStopEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BottomDepth field</summary>
        /// <returns>Returns nullable float representing the BottomDepth field</returns>
        public float? GetBottomDepth()
        {
            Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BottomDepth field</summary>
        /// <param name="bottomDepth_">Nullable field value to be set</param>
        public void SetBottomDepth(float? bottomDepth_)
        {
            SetFieldValue(10, 0, bottomDepth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BottomTime field</summary>
        /// <returns>Returns nullable uint representing the BottomTime field</returns>
        public uint? GetBottomTime()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set BottomTime field</summary>
        /// <param name="bottomTime_">Nullable field value to be set</param>
        public void SetBottomTime(uint? bottomTime_)
        {
            SetFieldValue(11, 0, bottomTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ApneaCountdownEnabled field</summary>
        /// <returns>Returns nullable Bool enum representing the ApneaCountdownEnabled field</returns>
        public Bool? GetApneaCountdownEnabled()
        {
            object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set ApneaCountdownEnabled field</summary>
        /// <param name="apneaCountdownEnabled_">Nullable field value to be set</param>
        public void SetApneaCountdownEnabled(Bool? apneaCountdownEnabled_)
        {
            SetFieldValue(12, 0, apneaCountdownEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ApneaCountdownTime field</summary>
        /// <returns>Returns nullable uint representing the ApneaCountdownTime field</returns>
        public uint? GetApneaCountdownTime()
        {
            Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set ApneaCountdownTime field</summary>
        /// <param name="apneaCountdownTime_">Nullable field value to be set</param>
        public void SetApneaCountdownTime(uint? apneaCountdownTime_)
        {
            SetFieldValue(13, 0, apneaCountdownTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BacklightMode field</summary>
        /// <returns>Returns nullable DiveBacklightMode enum representing the BacklightMode field</returns>
        public DiveBacklightMode? GetBacklightMode()
        {
            object obj = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            DiveBacklightMode? value = obj == null ? (DiveBacklightMode?)null : (DiveBacklightMode)obj;
            return value;
        }

        /// <summary>
        /// Set BacklightMode field</summary>
        /// <param name="backlightMode_">Nullable field value to be set</param>
        public void SetBacklightMode(DiveBacklightMode? backlightMode_)
        {
            SetFieldValue(14, 0, backlightMode_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BacklightBrightness field</summary>
        /// <returns>Returns nullable byte representing the BacklightBrightness field</returns>
        public byte? GetBacklightBrightness()
        {
            Object val = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BacklightBrightness field</summary>
        /// <param name="backlightBrightness_">Nullable field value to be set</param>
        public void SetBacklightBrightness(byte? backlightBrightness_)
        {
            SetFieldValue(15, 0, backlightBrightness_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BacklightTimeout field</summary>
        /// <returns>Returns nullable byte representing the BacklightTimeout field</returns>
        public byte? GetBacklightTimeout()
        {
            Object val = GetFieldValue(16, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set BacklightTimeout field</summary>
        /// <param name="backlightTimeout_">Nullable field value to be set</param>
        public void SetBacklightTimeout(byte? backlightTimeout_)
        {
            SetFieldValue(16, 0, backlightTimeout_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the RepeatDiveInterval field
        /// Units: s
        /// Comment: Time between surfacing and ending the activity</summary>
        /// <returns>Returns nullable ushort representing the RepeatDiveInterval field</returns>
        public ushort? GetRepeatDiveInterval()
        {
            Object val = GetFieldValue(17, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set RepeatDiveInterval field
        /// Units: s
        /// Comment: Time between surfacing and ending the activity</summary>
        /// <param name="repeatDiveInterval_">Nullable field value to be set</param>
        public void SetRepeatDiveInterval(ushort? repeatDiveInterval_)
        {
            SetFieldValue(17, 0, repeatDiveInterval_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SafetyStopTime field
        /// Units: s
        /// Comment: Time at safety stop (if enabled)</summary>
        /// <returns>Returns nullable ushort representing the SafetyStopTime field</returns>
        public ushort? GetSafetyStopTime()
        {
            Object val = GetFieldValue(18, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set SafetyStopTime field
        /// Units: s
        /// Comment: Time at safety stop (if enabled)</summary>
        /// <param name="safetyStopTime_">Nullable field value to be set</param>
        public void SetSafetyStopTime(ushort? safetyStopTime_)
        {
            SetFieldValue(18, 0, safetyStopTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HeartRateSourceType field</summary>
        /// <returns>Returns nullable SourceType enum representing the HeartRateSourceType field</returns>
        public SourceType? GetHeartRateSourceType()
        {
            object obj = GetFieldValue(19, 0, Fit.SubfieldIndexMainField);
            SourceType? value = obj == null ? (SourceType?)null : (SourceType)obj;
            return value;
        }

        /// <summary>
        /// Set HeartRateSourceType field</summary>
        /// <param name="heartRateSourceType_">Nullable field value to be set</param>
        public void SetHeartRateSourceType(SourceType? heartRateSourceType_)
        {
            SetFieldValue(19, 0, heartRateSourceType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HeartRateSource field</summary>
        /// <returns>Returns nullable byte representing the HeartRateSource field</returns>
        public byte? GetHeartRateSource()
        {
            Object val = GetFieldValue(20, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set HeartRateSource field</summary>
        /// <param name="heartRateSource_">Nullable field value to be set</param>
        public void SetHeartRateSource(byte? heartRateSource_)
        {
            SetFieldValue(20, 0, heartRateSource_, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Retrieves the HeartRateAntplusDeviceType subfield</summary>
        /// <returns>Nullable byte representing the HeartRateAntplusDeviceType subfield</returns>
        public byte? GetHeartRateAntplusDeviceType()
        {
            Object val = GetFieldValue(20, 0, HeartRateSourceSubfield.HeartRateAntplusDeviceType);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        ///
        /// Set HeartRateAntplusDeviceType subfield</summary>
        /// <param name="heartRateAntplusDeviceType">Subfield value to be set</param>
        public void SetHeartRateAntplusDeviceType(byte? heartRateAntplusDeviceType)
        {
            SetFieldValue(20, 0, heartRateAntplusDeviceType, HeartRateSourceSubfield.HeartRateAntplusDeviceType);
        }

        /// <summary>
        /// Retrieves the HeartRateLocalDeviceType subfield</summary>
        /// <returns>Nullable byte representing the HeartRateLocalDeviceType subfield</returns>
        public byte? GetHeartRateLocalDeviceType()
        {
            Object val = GetFieldValue(20, 0, HeartRateSourceSubfield.HeartRateLocalDeviceType);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        ///
        /// Set HeartRateLocalDeviceType subfield</summary>
        /// <param name="heartRateLocalDeviceType">Subfield value to be set</param>
        public void SetHeartRateLocalDeviceType(byte? heartRateLocalDeviceType)
        {
            SetFieldValue(20, 0, heartRateLocalDeviceType, HeartRateSourceSubfield.HeartRateLocalDeviceType);
        }
        ///<summary>
        /// Retrieves the TravelGas field
        /// Comment: Index of travel dive_gas message</summary>
        /// <returns>Returns nullable ushort representing the TravelGas field</returns>
        public ushort? GetTravelGas()
        {
            Object val = GetFieldValue(21, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set TravelGas field
        /// Comment: Index of travel dive_gas message</summary>
        /// <param name="travelGas_">Nullable field value to be set</param>
        public void SetTravelGas(ushort? travelGas_)
        {
            SetFieldValue(21, 0, travelGas_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CcrLowSetpointSwitchMode field
        /// Comment: If low PO2 should be switched to automatically</summary>
        /// <returns>Returns nullable CcrSetpointSwitchMode enum representing the CcrLowSetpointSwitchMode field</returns>
        public CcrSetpointSwitchMode? GetCcrLowSetpointSwitchMode()
        {
            object obj = GetFieldValue(22, 0, Fit.SubfieldIndexMainField);
            CcrSetpointSwitchMode? value = obj == null ? (CcrSetpointSwitchMode?)null : (CcrSetpointSwitchMode)obj;
            return value;
        }

        /// <summary>
        /// Set CcrLowSetpointSwitchMode field
        /// Comment: If low PO2 should be switched to automatically</summary>
        /// <param name="ccrLowSetpointSwitchMode_">Nullable field value to be set</param>
        public void SetCcrLowSetpointSwitchMode(CcrSetpointSwitchMode? ccrLowSetpointSwitchMode_)
        {
            SetFieldValue(22, 0, ccrLowSetpointSwitchMode_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CcrLowSetpoint field
        /// Units: percent
        /// Comment: Target PO2 when using low setpoint</summary>
        /// <returns>Returns nullable float representing the CcrLowSetpoint field</returns>
        public float? GetCcrLowSetpoint()
        {
            Object val = GetFieldValue(23, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CcrLowSetpoint field
        /// Units: percent
        /// Comment: Target PO2 when using low setpoint</summary>
        /// <param name="ccrLowSetpoint_">Nullable field value to be set</param>
        public void SetCcrLowSetpoint(float? ccrLowSetpoint_)
        {
            SetFieldValue(23, 0, ccrLowSetpoint_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CcrLowSetpointDepth field
        /// Units: m
        /// Comment: Depth to switch to low setpoint in automatic mode</summary>
        /// <returns>Returns nullable float representing the CcrLowSetpointDepth field</returns>
        public float? GetCcrLowSetpointDepth()
        {
            Object val = GetFieldValue(24, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CcrLowSetpointDepth field
        /// Units: m
        /// Comment: Depth to switch to low setpoint in automatic mode</summary>
        /// <param name="ccrLowSetpointDepth_">Nullable field value to be set</param>
        public void SetCcrLowSetpointDepth(float? ccrLowSetpointDepth_)
        {
            SetFieldValue(24, 0, ccrLowSetpointDepth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CcrHighSetpointSwitchMode field
        /// Comment: If high PO2 should be switched to automatically</summary>
        /// <returns>Returns nullable CcrSetpointSwitchMode enum representing the CcrHighSetpointSwitchMode field</returns>
        public CcrSetpointSwitchMode? GetCcrHighSetpointSwitchMode()
        {
            object obj = GetFieldValue(25, 0, Fit.SubfieldIndexMainField);
            CcrSetpointSwitchMode? value = obj == null ? (CcrSetpointSwitchMode?)null : (CcrSetpointSwitchMode)obj;
            return value;
        }

        /// <summary>
        /// Set CcrHighSetpointSwitchMode field
        /// Comment: If high PO2 should be switched to automatically</summary>
        /// <param name="ccrHighSetpointSwitchMode_">Nullable field value to be set</param>
        public void SetCcrHighSetpointSwitchMode(CcrSetpointSwitchMode? ccrHighSetpointSwitchMode_)
        {
            SetFieldValue(25, 0, ccrHighSetpointSwitchMode_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CcrHighSetpoint field
        /// Units: percent
        /// Comment: Target PO2 when using high setpoint</summary>
        /// <returns>Returns nullable float representing the CcrHighSetpoint field</returns>
        public float? GetCcrHighSetpoint()
        {
            Object val = GetFieldValue(26, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CcrHighSetpoint field
        /// Units: percent
        /// Comment: Target PO2 when using high setpoint</summary>
        /// <param name="ccrHighSetpoint_">Nullable field value to be set</param>
        public void SetCcrHighSetpoint(float? ccrHighSetpoint_)
        {
            SetFieldValue(26, 0, ccrHighSetpoint_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CcrHighSetpointDepth field
        /// Units: m
        /// Comment: Depth to switch to high setpoint in automatic mode</summary>
        /// <returns>Returns nullable float representing the CcrHighSetpointDepth field</returns>
        public float? GetCcrHighSetpointDepth()
        {
            Object val = GetFieldValue(27, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set CcrHighSetpointDepth field
        /// Units: m
        /// Comment: Depth to switch to high setpoint in automatic mode</summary>
        /// <param name="ccrHighSetpointDepth_">Nullable field value to be set</param>
        public void SetCcrHighSetpointDepth(float? ccrHighSetpointDepth_)
        {
            SetFieldValue(27, 0, ccrHighSetpointDepth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the GasConsumptionDisplay field
        /// Comment: Type of gas consumption rate to display. Some values are only valid if tank volume is known.</summary>
        /// <returns>Returns nullable GasConsumptionRateType enum representing the GasConsumptionDisplay field</returns>
        public GasConsumptionRateType? GetGasConsumptionDisplay()
        {
            object obj = GetFieldValue(29, 0, Fit.SubfieldIndexMainField);
            GasConsumptionRateType? value = obj == null ? (GasConsumptionRateType?)null : (GasConsumptionRateType)obj;
            return value;
        }

        /// <summary>
        /// Set GasConsumptionDisplay field
        /// Comment: Type of gas consumption rate to display. Some values are only valid if tank volume is known.</summary>
        /// <param name="gasConsumptionDisplay_">Nullable field value to be set</param>
        public void SetGasConsumptionDisplay(GasConsumptionRateType? gasConsumptionDisplay_)
        {
            SetFieldValue(29, 0, gasConsumptionDisplay_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UpKeyEnabled field
        /// Comment: Indicates whether the up key is enabled during dives</summary>
        /// <returns>Returns nullable Bool enum representing the UpKeyEnabled field</returns>
        public Bool? GetUpKeyEnabled()
        {
            object obj = GetFieldValue(30, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set UpKeyEnabled field
        /// Comment: Indicates whether the up key is enabled during dives</summary>
        /// <param name="upKeyEnabled_">Nullable field value to be set</param>
        public void SetUpKeyEnabled(Bool? upKeyEnabled_)
        {
            SetFieldValue(30, 0, upKeyEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DiveSounds field
        /// Comment: Sounds and vibration enabled or disabled in-dive</summary>
        /// <returns>Returns nullable Tone enum representing the DiveSounds field</returns>
        public Tone? GetDiveSounds()
        {
            object obj = GetFieldValue(35, 0, Fit.SubfieldIndexMainField);
            Tone? value = obj == null ? (Tone?)null : (Tone)obj;
            return value;
        }

        /// <summary>
        /// Set DiveSounds field
        /// Comment: Sounds and vibration enabled or disabled in-dive</summary>
        /// <param name="diveSounds_">Nullable field value to be set</param>
        public void SetDiveSounds(Tone? diveSounds_)
        {
            SetFieldValue(35, 0, diveSounds_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LastStopMultiple field
        /// Comment: Usually 1.0/1.5/2.0 representing 3/4.5/6m or 10/15/20ft</summary>
        /// <returns>Returns nullable float representing the LastStopMultiple field</returns>
        public float? GetLastStopMultiple()
        {
            Object val = GetFieldValue(36, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set LastStopMultiple field
        /// Comment: Usually 1.0/1.5/2.0 representing 3/4.5/6m or 10/15/20ft</summary>
        /// <param name="lastStopMultiple_">Nullable field value to be set</param>
        public void SetLastStopMultiple(float? lastStopMultiple_)
        {
            SetFieldValue(36, 0, lastStopMultiple_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the NoFlyTimeMode field
        /// Comment: Indicates which guidelines to use for no-fly surface interval.</summary>
        /// <returns>Returns nullable NoFlyTimeMode enum representing the NoFlyTimeMode field</returns>
        public NoFlyTimeMode? GetNoFlyTimeMode()
        {
            object obj = GetFieldValue(37, 0, Fit.SubfieldIndexMainField);
            NoFlyTimeMode? value = obj == null ? (NoFlyTimeMode?)null : (NoFlyTimeMode)obj;
            return value;
        }

        /// <summary>
        /// Set NoFlyTimeMode field
        /// Comment: Indicates which guidelines to use for no-fly surface interval.</summary>
        /// <param name="noFlyTimeMode_">Nullable field value to be set</param>
        public void SetNoFlyTimeMode(NoFlyTimeMode? noFlyTimeMode_)
        {
            SetFieldValue(37, 0, noFlyTimeMode_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

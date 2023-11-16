#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.126.0Release
// Tag = production/release/21.126.0-0-g0576dfe
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile LocalDeviceType type as a class
    /// </summary>
    public static class LocalDeviceType 
    {
        public const byte Gps = 0; // Onboard gps receiver
        public const byte Glonass = 1; // Onboard glonass receiver
        public const byte GpsGlonass = 2; // Onboard gps glonass receiver
        public const byte Accelerometer = 3; // Onboard sensor
        public const byte Barometer = 4; // Onboard sensor
        public const byte Temperature = 5; // Onboard sensor
        public const byte Whr = 10; // Onboard wrist HR sensor
        public const byte SensorHub = 12; // Onboard software package
        public const byte Invalid = (byte)0xFF;


    }
}


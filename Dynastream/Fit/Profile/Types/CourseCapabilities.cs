#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.158.0Release
// Tag = production/release/21.158.0-0-gc9428aa
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile CourseCapabilities type as a class
    /// </summary>
    public static class CourseCapabilities 
    {
        public const uint Processed = 0x00000001;
        public const uint Valid = 0x00000002;
        public const uint Time = 0x00000004;
        public const uint Distance = 0x00000008;
        public const uint Position = 0x00000010;
        public const uint HeartRate = 0x00000020;
        public const uint Power = 0x00000040;
        public const uint Cadence = 0x00000080;
        public const uint Training = 0x00000100;
        public const uint Navigation = 0x00000200;
        public const uint Bikeway = 0x00000400;
        public const uint Aviation = 0x00001000; // Denote course files to be used as flight plans
        public const uint Invalid = (uint)0x00000000;


    }
}


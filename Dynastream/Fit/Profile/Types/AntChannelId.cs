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
    /// Implements the profile AntChannelId type as a class
    /// </summary>
    public static class AntChannelId 
    {
        public const uint AntExtendedDeviceNumberUpperNibble = 0xF0000000;
        public const uint AntTransmissionTypeLowerNibble = 0x0F000000;
        public const uint AntDeviceType = 0x00FF0000;
        public const uint AntDeviceNumber = 0x0000FFFF;
        public const uint Invalid = (uint)0x00000000;


    }
}


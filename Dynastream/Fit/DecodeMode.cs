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

namespace Dynastream.Fit
{
    /// <summary>
    /// Mode used for Read Operations
    /// </summary>
    public enum DecodeMode
    {
        /// <summary>
        /// Indicates that file contains valid Header and CRC data
        /// </summary>
        Normal,

        /// <summary>
        /// Indicates that the Stream Contains a Header that is Corrupt
        /// </summary>
        InvalidHeader,

        /// <summary>
        /// Indicates that the Stream does not contain a Header or CRC
        /// </summary>
        DataOnly
    }
}

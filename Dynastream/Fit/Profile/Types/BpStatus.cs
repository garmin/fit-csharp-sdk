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
    /// Implements the profile BpStatus type as an enum
    /// </summary>
    public enum BpStatus : byte
    {
        NoError = 0,
        ErrorIncompleteData = 1,
        ErrorNoMeasurement = 2,
        ErrorDataOutOfRange = 3,
        ErrorIrregularHeartRate = 4,
        Invalid = 0xFF


    }
}


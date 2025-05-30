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

namespace Dynastream.Fit
{
    /// <summary>
    /// Extends System.Exception to provide application specific exceptions.
    /// </summary>
    public class FitException : Exception
    {
        #region Constructors
        public FitException()
            : base()
        {
        }

        public FitException(string message)
            : base(message)
        {
        }

        public FitException(string str, Exception e)
            : base(str, e)
        {
        }
        #endregion
    }
} // namespace

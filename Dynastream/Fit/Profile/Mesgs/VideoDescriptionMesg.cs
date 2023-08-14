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
    /// Implements the VideoDescription profile message.
    /// </summary>
    public class VideoDescriptionMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="VideoDescriptionMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte MessageCount = 0;
            public const byte Text = 1;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public VideoDescriptionMesg() : base(Profile.GetMesg(MesgNum.VideoDescription))
        {
        }

        public VideoDescriptionMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field
        /// Comment: Long descriptions will be split into multiple parts</summary>
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
        /// Set MessageIndex field
        /// Comment: Long descriptions will be split into multiple parts</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MessageCount field
        /// Comment: Total number of description parts</summary>
        /// <returns>Returns nullable ushort representing the MessageCount field</returns>
        public ushort? GetMessageCount()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageCount field
        /// Comment: Total number of description parts</summary>
        /// <param name="messageCount_">Nullable field value to be set</param>
        public void SetMessageCount(ushort? messageCount_)
        {
            SetFieldValue(0, 0, messageCount_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Text field</summary>
        /// <returns>Returns byte[] representing the Text field</returns>
        public byte[] GetText()
        {
            byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Text field</summary>
        /// <returns>Returns String representing the Text field</returns>
        public String GetTextAsString()
        {
            byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Text field</summary>
        /// <param name="text_"> field value to be set</param>
        public void SetText(String text_)
        {
            byte[] data = Encoding.UTF8.GetBytes(text_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(1, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Text field</summary>
        /// <param name="text_">field value to be set</param>
        public void SetText(byte[] text_)
        {
            SetFieldValue(1, 0, text_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

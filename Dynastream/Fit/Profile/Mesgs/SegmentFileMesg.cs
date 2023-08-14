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
    /// Implements the SegmentFile profile message.
    /// </summary>
    public class SegmentFileMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="SegmentFileMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte FileUuid = 1;
            public const byte Enabled = 3;
            public const byte UserProfilePrimaryKey = 4;
            public const byte LeaderType = 7;
            public const byte LeaderGroupPrimaryKey = 8;
            public const byte LeaderActivityId = 9;
            public const byte LeaderActivityIdString = 10;
            public const byte DefaultRaceLeader = 11;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public SegmentFileMesg() : base(Profile.GetMesg(MesgNum.SegmentFile))
        {
        }

        public SegmentFileMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
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
        /// Retrieves the FileUuid field
        /// Comment: UUID of the segment file</summary>
        /// <returns>Returns byte[] representing the FileUuid field</returns>
        public byte[] GetFileUuid()
        {
            byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the FileUuid field
        /// Comment: UUID of the segment file</summary>
        /// <returns>Returns String representing the FileUuid field</returns>
        public String GetFileUuidAsString()
        {
            byte[] data = (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set FileUuid field
        /// Comment: UUID of the segment file</summary>
        /// <param name="fileUuid_"> field value to be set</param>
        public void SetFileUuid(String fileUuid_)
        {
            byte[] data = Encoding.UTF8.GetBytes(fileUuid_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(1, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set FileUuid field
        /// Comment: UUID of the segment file</summary>
        /// <param name="fileUuid_">field value to be set</param>
        public void SetFileUuid(byte[] fileUuid_)
        {
            SetFieldValue(1, 0, fileUuid_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Enabled field
        /// Comment: Enabled state of the segment file</summary>
        /// <returns>Returns nullable Bool enum representing the Enabled field</returns>
        public Bool? GetEnabled()
        {
            object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Enabled field
        /// Comment: Enabled state of the segment file</summary>
        /// <param name="enabled_">Nullable field value to be set</param>
        public void SetEnabled(Bool? enabled_)
        {
            SetFieldValue(3, 0, enabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UserProfilePrimaryKey field
        /// Comment: Primary key of the user that created the segment file</summary>
        /// <returns>Returns nullable uint representing the UserProfilePrimaryKey field</returns>
        public uint? GetUserProfilePrimaryKey()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set UserProfilePrimaryKey field
        /// Comment: Primary key of the user that created the segment file</summary>
        /// <param name="userProfilePrimaryKey_">Nullable field value to be set</param>
        public void SetUserProfilePrimaryKey(uint? userProfilePrimaryKey_)
        {
            SetFieldValue(4, 0, userProfilePrimaryKey_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field LeaderType</returns>
        public int GetNumLeaderType()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the LeaderType field
        /// Comment: Leader type of each leader in the segment file</summary>
        /// <param name="index">0 based index of LeaderType element to retrieve</param>
        /// <returns>Returns nullable SegmentLeaderboardType enum representing the LeaderType field</returns>
        public SegmentLeaderboardType? GetLeaderType(int index)
        {
            object obj = GetFieldValue(7, index, Fit.SubfieldIndexMainField);
            SegmentLeaderboardType? value = obj == null ? (SegmentLeaderboardType?)null : (SegmentLeaderboardType)obj;
            return value;
        }

        /// <summary>
        /// Set LeaderType field
        /// Comment: Leader type of each leader in the segment file</summary>
        /// <param name="index">0 based index of leader_type</param>
        /// <param name="leaderType_">Nullable field value to be set</param>
        public void SetLeaderType(int index, SegmentLeaderboardType? leaderType_)
        {
            SetFieldValue(7, index, leaderType_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field LeaderGroupPrimaryKey</returns>
        public int GetNumLeaderGroupPrimaryKey()
        {
            return GetNumFieldValues(8, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the LeaderGroupPrimaryKey field
        /// Comment: Group primary key of each leader in the segment file</summary>
        /// <param name="index">0 based index of LeaderGroupPrimaryKey element to retrieve</param>
        /// <returns>Returns nullable uint representing the LeaderGroupPrimaryKey field</returns>
        public uint? GetLeaderGroupPrimaryKey(int index)
        {
            Object val = GetFieldValue(8, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set LeaderGroupPrimaryKey field
        /// Comment: Group primary key of each leader in the segment file</summary>
        /// <param name="index">0 based index of leader_group_primary_key</param>
        /// <param name="leaderGroupPrimaryKey_">Nullable field value to be set</param>
        public void SetLeaderGroupPrimaryKey(int index, uint? leaderGroupPrimaryKey_)
        {
            SetFieldValue(8, index, leaderGroupPrimaryKey_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field LeaderActivityId</returns>
        public int GetNumLeaderActivityId()
        {
            return GetNumFieldValues(9, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the LeaderActivityId field
        /// Comment: Activity ID of each leader in the segment file</summary>
        /// <param name="index">0 based index of LeaderActivityId element to retrieve</param>
        /// <returns>Returns nullable uint representing the LeaderActivityId field</returns>
        public uint? GetLeaderActivityId(int index)
        {
            Object val = GetFieldValue(9, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set LeaderActivityId field
        /// Comment: Activity ID of each leader in the segment file</summary>
        /// <param name="index">0 based index of leader_activity_id</param>
        /// <param name="leaderActivityId_">Nullable field value to be set</param>
        public void SetLeaderActivityId(int index, uint? leaderActivityId_)
        {
            SetFieldValue(9, index, leaderActivityId_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field LeaderActivityIdString</returns>
        public int GetNumLeaderActivityIdString()
        {
            return GetNumFieldValues(10, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the LeaderActivityIdString field
        /// Comment: String version of the activity ID of each leader in the segment file. 21 characters long for each ID, express in decimal</summary>
        /// <param name="index">0 based index of LeaderActivityIdString element to retrieve</param>
        /// <returns>Returns byte[] representing the LeaderActivityIdString field</returns>
        public byte[] GetLeaderActivityIdString(int index)
        {
            byte[] data = (byte[])GetFieldValue(10, index, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the LeaderActivityIdString field
        /// Comment: String version of the activity ID of each leader in the segment file. 21 characters long for each ID, express in decimal</summary>
        /// <param name="index">0 based index of LeaderActivityIdString element to retrieve</param>
        /// <returns>Returns String representing the LeaderActivityIdString field</returns>
        public String GetLeaderActivityIdStringAsString(int index)
        {
            byte[] data = (byte[])GetFieldValue(10, index, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set LeaderActivityIdString field
        /// Comment: String version of the activity ID of each leader in the segment file. 21 characters long for each ID, express in decimal</summary>
        /// <param name="index">0 based index of LeaderActivityIdString element to retrieve</param>
        /// <param name="leaderActivityIdString_"> field value to be set</param>
        public void SetLeaderActivityIdString(int index, String leaderActivityIdString_)
        {
            byte[] data = Encoding.UTF8.GetBytes(leaderActivityIdString_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(10, index, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set LeaderActivityIdString field
        /// Comment: String version of the activity ID of each leader in the segment file. 21 characters long for each ID, express in decimal</summary>
        /// <param name="index">0 based index of leader_activity_id_string</param>
        /// <param name="leaderActivityIdString_">field value to be set</param>
        public void SetLeaderActivityIdString(int index, byte[] leaderActivityIdString_)
        {
            SetFieldValue(10, index, leaderActivityIdString_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DefaultRaceLeader field
        /// Comment: Index for the Leader Board entry selected as the default race participant</summary>
        /// <returns>Returns nullable byte representing the DefaultRaceLeader field</returns>
        public byte? GetDefaultRaceLeader()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set DefaultRaceLeader field
        /// Comment: Index for the Leader Board entry selected as the default race participant</summary>
        /// <param name="defaultRaceLeader_">Nullable field value to be set</param>
        public void SetDefaultRaceLeader(byte? defaultRaceLeader_)
        {
            SetFieldValue(11, 0, defaultRaceLeader_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

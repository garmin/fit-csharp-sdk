#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.120Release
// Tag = production/release/21.120.00-0-g2d77811
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
    /// Implements the WeightScale profile message.
    /// </summary>
    public class WeightScaleMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="WeightScaleMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte Weight = 0;
            public const byte PercentFat = 1;
            public const byte PercentHydration = 2;
            public const byte VisceralFatMass = 3;
            public const byte BoneMass = 4;
            public const byte MuscleMass = 5;
            public const byte BasalMet = 7;
            public const byte PhysiqueRating = 8;
            public const byte ActiveMet = 9;
            public const byte MetabolicAge = 10;
            public const byte VisceralFatRating = 11;
            public const byte UserProfileIndex = 12;
            public const byte Bmi = 13;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public WeightScaleMesg() : base(Profile.GetMesg(MesgNum.WeightScale))
        {
        }

        public WeightScaleMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s</summary>
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
        /// Units: s</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Weight field
        /// Units: kg</summary>
        /// <returns>Returns nullable float representing the Weight field</returns>
        public float? GetWeight()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Weight field
        /// Units: kg</summary>
        /// <param name="weight_">Nullable field value to be set</param>
        public void SetWeight(float? weight_)
        {
            SetFieldValue(0, 0, weight_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PercentFat field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the PercentFat field</returns>
        public float? GetPercentFat()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set PercentFat field
        /// Units: %</summary>
        /// <param name="percentFat_">Nullable field value to be set</param>
        public void SetPercentFat(float? percentFat_)
        {
            SetFieldValue(1, 0, percentFat_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PercentHydration field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the PercentHydration field</returns>
        public float? GetPercentHydration()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set PercentHydration field
        /// Units: %</summary>
        /// <param name="percentHydration_">Nullable field value to be set</param>
        public void SetPercentHydration(float? percentHydration_)
        {
            SetFieldValue(2, 0, percentHydration_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the VisceralFatMass field
        /// Units: kg</summary>
        /// <returns>Returns nullable float representing the VisceralFatMass field</returns>
        public float? GetVisceralFatMass()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set VisceralFatMass field
        /// Units: kg</summary>
        /// <param name="visceralFatMass_">Nullable field value to be set</param>
        public void SetVisceralFatMass(float? visceralFatMass_)
        {
            SetFieldValue(3, 0, visceralFatMass_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BoneMass field
        /// Units: kg</summary>
        /// <returns>Returns nullable float representing the BoneMass field</returns>
        public float? GetBoneMass()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BoneMass field
        /// Units: kg</summary>
        /// <param name="boneMass_">Nullable field value to be set</param>
        public void SetBoneMass(float? boneMass_)
        {
            SetFieldValue(4, 0, boneMass_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MuscleMass field
        /// Units: kg</summary>
        /// <returns>Returns nullable float representing the MuscleMass field</returns>
        public float? GetMuscleMass()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set MuscleMass field
        /// Units: kg</summary>
        /// <param name="muscleMass_">Nullable field value to be set</param>
        public void SetMuscleMass(float? muscleMass_)
        {
            SetFieldValue(5, 0, muscleMass_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BasalMet field
        /// Units: kcal/day</summary>
        /// <returns>Returns nullable float representing the BasalMet field</returns>
        public float? GetBasalMet()
        {
            Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set BasalMet field
        /// Units: kcal/day</summary>
        /// <param name="basalMet_">Nullable field value to be set</param>
        public void SetBasalMet(float? basalMet_)
        {
            SetFieldValue(7, 0, basalMet_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PhysiqueRating field</summary>
        /// <returns>Returns nullable byte representing the PhysiqueRating field</returns>
        public byte? GetPhysiqueRating()
        {
            Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set PhysiqueRating field</summary>
        /// <param name="physiqueRating_">Nullable field value to be set</param>
        public void SetPhysiqueRating(byte? physiqueRating_)
        {
            SetFieldValue(8, 0, physiqueRating_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActiveMet field
        /// Units: kcal/day
        /// Comment: ~4kJ per kcal, 0.25 allows max 16384 kcal</summary>
        /// <returns>Returns nullable float representing the ActiveMet field</returns>
        public float? GetActiveMet()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set ActiveMet field
        /// Units: kcal/day
        /// Comment: ~4kJ per kcal, 0.25 allows max 16384 kcal</summary>
        /// <param name="activeMet_">Nullable field value to be set</param>
        public void SetActiveMet(float? activeMet_)
        {
            SetFieldValue(9, 0, activeMet_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MetabolicAge field
        /// Units: years</summary>
        /// <returns>Returns nullable byte representing the MetabolicAge field</returns>
        public byte? GetMetabolicAge()
        {
            Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set MetabolicAge field
        /// Units: years</summary>
        /// <param name="metabolicAge_">Nullable field value to be set</param>
        public void SetMetabolicAge(byte? metabolicAge_)
        {
            SetFieldValue(10, 0, metabolicAge_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the VisceralFatRating field</summary>
        /// <returns>Returns nullable byte representing the VisceralFatRating field</returns>
        public byte? GetVisceralFatRating()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set VisceralFatRating field</summary>
        /// <param name="visceralFatRating_">Nullable field value to be set</param>
        public void SetVisceralFatRating(byte? visceralFatRating_)
        {
            SetFieldValue(11, 0, visceralFatRating_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UserProfileIndex field
        /// Comment: Associates this weight scale message to a user. This corresponds to the index of the user profile message in the weight scale file.</summary>
        /// <returns>Returns nullable ushort representing the UserProfileIndex field</returns>
        public ushort? GetUserProfileIndex()
        {
            Object val = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set UserProfileIndex field
        /// Comment: Associates this weight scale message to a user. This corresponds to the index of the user profile message in the weight scale file.</summary>
        /// <param name="userProfileIndex_">Nullable field value to be set</param>
        public void SetUserProfileIndex(ushort? userProfileIndex_)
        {
            SetFieldValue(12, 0, userProfileIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Bmi field
        /// Units: kg/m^2</summary>
        /// <returns>Returns nullable float representing the Bmi field</returns>
        public float? GetBmi()
        {
            Object val = GetFieldValue(13, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Bmi field
        /// Units: kg/m^2</summary>
        /// <param name="bmi_">Nullable field value to be set</param>
        public void SetBmi(float? bmi_)
        {
            SetFieldValue(13, 0, bmi_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

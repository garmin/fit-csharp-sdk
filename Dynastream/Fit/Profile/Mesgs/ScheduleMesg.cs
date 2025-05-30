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
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the Schedule profile message.
    /// </summary>
    public class ScheduleMesg : Mesg
    {
        #region Fields
        static class ProductSubfield
        {
            public static ushort FaveroProduct = 0;
            public static ushort GarminProduct = 1;
            public static ushort Subfields = 2;
            public static ushort Active = Fit.SubfieldIndexActiveSubfield;
            public static ushort MainField = Fit.SubfieldIndexMainField;
        }
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="ScheduleMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Manufacturer = 0;
            public const byte Product = 1;
            public const byte SerialNumber = 2;
            public const byte TimeCreated = 3;
            public const byte Completed = 4;
            public const byte Type = 5;
            public const byte ScheduledTime = 6;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public ScheduleMesg() : base(Profile.GetMesg(MesgNum.Schedule))
        {
        }

        public ScheduleMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Manufacturer field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <returns>Returns nullable ushort representing the Manufacturer field</returns>
        public ushort? GetManufacturer()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Manufacturer field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <param name="manufacturer_">Nullable field value to be set</param>
        public void SetManufacturer(ushort? manufacturer_)
        {
            SetFieldValue(0, 0, manufacturer_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Product field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <returns>Returns nullable ushort representing the Product field</returns>
        public ushort? GetProduct()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Product field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <param name="product_">Nullable field value to be set</param>
        public void SetProduct(ushort? product_)
        {
            SetFieldValue(1, 0, product_, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Retrieves the FaveroProduct subfield</summary>
        /// <returns>Nullable ushort representing the FaveroProduct subfield</returns>
        public ushort? GetFaveroProduct()
        {
            Object val = GetFieldValue(1, 0, ProductSubfield.FaveroProduct);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        ///
        /// Set FaveroProduct subfield</summary>
        /// <param name="faveroProduct">Subfield value to be set</param>
        public void SetFaveroProduct(ushort? faveroProduct)
        {
            SetFieldValue(1, 0, faveroProduct, ProductSubfield.FaveroProduct);
        }

        /// <summary>
        /// Retrieves the GarminProduct subfield</summary>
        /// <returns>Nullable ushort representing the GarminProduct subfield</returns>
        public ushort? GetGarminProduct()
        {
            Object val = GetFieldValue(1, 0, ProductSubfield.GarminProduct);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        ///
        /// Set GarminProduct subfield</summary>
        /// <param name="garminProduct">Subfield value to be set</param>
        public void SetGarminProduct(ushort? garminProduct)
        {
            SetFieldValue(1, 0, garminProduct, ProductSubfield.GarminProduct);
        }
        ///<summary>
        /// Retrieves the SerialNumber field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <returns>Returns nullable uint representing the SerialNumber field</returns>
        public uint? GetSerialNumber()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set SerialNumber field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <param name="serialNumber_">Nullable field value to be set</param>
        public void SetSerialNumber(uint? serialNumber_)
        {
            SetFieldValue(2, 0, serialNumber_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimeCreated field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <returns>Returns DateTime representing the TimeCreated field</returns>
        public DateTime GetTimeCreated()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set TimeCreated field
        /// Comment: Corresponds to file_id of scheduled workout / course.</summary>
        /// <param name="timeCreated_">Nullable field value to be set</param>
        public void SetTimeCreated(DateTime timeCreated_)
        {
            SetFieldValue(3, 0, timeCreated_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Completed field
        /// Comment: TRUE if this activity has been started</summary>
        /// <returns>Returns nullable Bool enum representing the Completed field</returns>
        public Bool? GetCompleted()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Completed field
        /// Comment: TRUE if this activity has been started</summary>
        /// <param name="completed_">Nullable field value to be set</param>
        public void SetCompleted(Bool? completed_)
        {
            SetFieldValue(4, 0, completed_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Type field</summary>
        /// <returns>Returns nullable Schedule enum representing the Type field</returns>
        new public Schedule? GetType()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            Schedule? value = obj == null ? (Schedule?)null : (Schedule)obj;
            return value;
        }

        /// <summary>
        /// Set Type field</summary>
        /// <param name="type_">Nullable field value to be set</param>
        public void SetType(Schedule? type_)
        {
            SetFieldValue(5, 0, type_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ScheduledTime field</summary>
        /// <returns>Returns nullable uint representing the ScheduledTime field</returns>
        public uint? GetScheduledTime()
        {
            Object val = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set ScheduledTime field</summary>
        /// <param name="scheduledTime_">Nullable field value to be set</param>
        public void SetScheduledTime(uint? scheduledTime_)
        {
            SetFieldValue(6, 0, scheduledTime_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace

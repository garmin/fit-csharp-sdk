#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.139.2Release
// Tag = production/release/21.139.2-0-g9eaea05
/////////////////////////////////////////////////////////////////////////////////////////////


#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    internal class DeveloperDataLookup
    {
        private readonly Dictionary<DeveloperDataKey, FieldDescriptionMesg> m_fieldDescriptionMesgs;
        private readonly Dictionary<byte, DeveloperDataIdMesg> m_developerDataIdMesgs;

        public DeveloperDataLookup()
        {
            m_fieldDescriptionMesgs = new Dictionary<DeveloperDataKey, FieldDescriptionMesg>();
            m_developerDataIdMesgs = new Dictionary<byte, DeveloperDataIdMesg>();
        }

        public Tuple<DeveloperDataIdMesg, FieldDescriptionMesg> GetMesgs(DeveloperDataKey key)
        {
            DeveloperDataIdMesg devIdMesg;
            FieldDescriptionMesg descriptionMesg;

            m_developerDataIdMesgs.TryGetValue(key.DeveloperDataIndex, out devIdMesg);
            m_fieldDescriptionMesgs.TryGetValue(key, out descriptionMesg);

            if (devIdMesg != null && descriptionMesg != null)
            {
                return new Tuple<DeveloperDataIdMesg, FieldDescriptionMesg>(
                    devIdMesg,
                    descriptionMesg);
            }

            return null;
        }

        public void Add(DeveloperDataIdMesg mesg)
        {
            byte? index = mesg.GetDeveloperDataIndex();
            if (index == null)
                return;

            m_developerDataIdMesgs[index.Value] = mesg;

            // Remove all fields currently associated with this developer
            var keysToRemove =
                m_fieldDescriptionMesgs.Keys
                                  .Where(
                                      x =>
                                          x.DeveloperDataIndex ==
                                          index)
                                  .ToList();
            foreach (var key in keysToRemove)
            {
                m_fieldDescriptionMesgs.Remove(key);
            }
        }

        public DeveloperFieldDescription Add(FieldDescriptionMesg mesg)
        {
            DeveloperFieldDescription desc = null;

            byte? developerDataIndex = mesg.GetDeveloperDataIndex();
            byte? fieldDefinitionNumber = mesg.GetFieldDefinitionNumber();
            if ((developerDataIndex != null) &&
                (fieldDefinitionNumber != null))
            {
                var key = new DeveloperDataKey(
                    (byte)developerDataIndex,
                    (byte)fieldDefinitionNumber);

                m_fieldDescriptionMesgs[key] = mesg;

                // Build a Description of the pairing we just created
                var pair = GetMesgs(key);
                if (pair != null)
                {
                    desc = new DeveloperFieldDescription(pair.Item1, pair.Item2);
                }
            }

            return desc;
        }
    }
} // namespace

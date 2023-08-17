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
using System.Linq;
using System.Text;

namespace Dynastream.Fit
{
    public class Accumulator
    {
        List<AccumulatedField> accumulatedFields;

        public Accumulator()
        {
            accumulatedFields = new List<AccumulatedField>();
        }

        public void Set(int mesgNum, int destFieldNum, long value)
        {
            AccumulatedField accumField = null;
            int i;

            for (i = 0; i < accumulatedFields.Count; i++)
            {
                accumField = accumulatedFields[i];

                if ((accumField.mesgNum == mesgNum) && (accumField.destFieldNum == destFieldNum))
                    break;
            }

            if (i == accumulatedFields.Count)
            {
                accumField = new AccumulatedField(mesgNum, destFieldNum);
                accumulatedFields.Add(accumField);
            }

            accumField.Set(value);
        }

        public long Accumulate(int mesgNum, int destFieldNum, long value, int bits)
        {
            AccumulatedField accumField = null;
            int i;
            for (i = 0; i < accumulatedFields.Count; i++)
            {
                accumField = accumulatedFields[i];

                if ((accumField.mesgNum == mesgNum) && (accumField.destFieldNum == destFieldNum))
                    break;
            }

            if (i == accumulatedFields.Count)
            {
                accumField = new AccumulatedField(mesgNum, destFieldNum);
                accumulatedFields.Add(accumField);
            }

            return accumField.Accumulate(value, bits);
        }
    }
}

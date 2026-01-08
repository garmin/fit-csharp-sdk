/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Text;
using Dynastream.Fit;

namespace Extensions
{
    public static class FitExtensions
    {
        public static System.DateTime FitEpoch = new System.DateTime(1989, 12, 31, 0, 0, 0, System.DateTimeKind.Utc);
        private const byte TimestampFieldId = 253;

        public static TimeSpan? TimezoneOffset(this ActivityMesg activity)
        {
            if (activity == null)
            {
                return null;
            }

            if (!activity.GetLocalTimestamp().HasValue)
            {
                return null;
            }
            return TimeSpan.FromSeconds((int)activity.GetLocalTimestamp() - (int)activity.GetTimestamp().GetTimeStamp());
        }
        public static System.DateTime LocalTimestampAsSystemDateTime(this ActivityMesg activity)
        {
            return new System.DateTime((long)(activity.GetLocalTimestamp() ?? 0) * 10000000L + FitEpoch.Ticks, DateTimeKind.Local);
        }

        public static Dynastream.Fit.DateTime LocalTimestampAsFitDateTime(this ActivityMesg activity)
        {
            return new Dynastream.Fit.DateTime(activity.GetLocalTimestamp() ?? 0);
        }

        public static Dynastream.Fit.DateTime GetTimestamp(this Mesg mesg)
        {
            Object val = mesg.GetFieldValue(TimestampFieldId);
            if (val == null)
            {
                return null;
            }

            return mesg.TimestampToDateTime(Convert.ToUInt32(val));
        }

        public static Dynastream.Fit.DateTime GetStartTime(this Mesg mesg)
        {
            Object val = mesg.GetFieldValue("StartTime");
            if (val == null)
            {
                return null;
            }

            return mesg.TimestampToDateTime(Convert.ToUInt32(val));

        }
        public static Dynastream.Fit.DateTime GetEndTime(this Mesg mesg)
        {
            var startTime = mesg.GetStartTime();
            if (startTime == null)
            {
                return null;
            }

            Object val = mesg.GetFieldValue("TotalElapsedTime");
            if (val == null)
            {
                return null;
            }

            startTime.Add(Convert.ToUInt32(val));
            return startTime;

        }

        public static string GetValueAsString(this Mesg mesg, String name)
        {
            Field field = mesg.GetField(name, false);
            if (field == null)
            {
                return null;
            }

            byte[] data = (byte[])field.GetValue();

            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        public static bool Overlaps(this Mesg mesg, SessionMesg session)
        {
            if (mesg.GetStartTime() == null || mesg.GetEndTime() == null || session.GetStartTime() == null || session.GetEndTime() == null)
            {
                return false;
            }

            return Math.Max(mesg.GetStartTime().GetTimeStamp(), session.GetStartTime().GetTimeStamp()) <=
                   Math.Min(mesg.GetEndTime().GetTimeStamp(), session.GetEndTime().GetTimeStamp());
        }

        public static bool Within(this Mesg mesg, SessionMesg session)
        {
            if (mesg.GetTimestamp() == null || session.GetStartTime() == null || session.GetEndTime() == null)
            {
                return false;
            }

            return mesg.GetTimestamp().GetDateTime() >= session.GetStartTime().GetDateTime()
                && mesg.GetTimestamp().GetDateTime() <= session.GetEndTime().GetDateTime();
        }
    }
}
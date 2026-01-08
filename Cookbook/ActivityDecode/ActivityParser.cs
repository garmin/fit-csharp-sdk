/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using Dynastream.Fit;
using Extensions;

public class ActivityParser
{
    private FitMessages _messages;
    public bool IsActivityFile => _firstFileIdMesg != null ? (_firstFileIdMesg.GetType() ?? File.Invalid) == File.Activity : false;

    public FileIdMesg _firstFileIdMesg => _messages.FileIdMesgs.FirstOrDefault();
    public ActivityMesg _activityMesg => _messages.ActivityMesgs.FirstOrDefault();

    public ActivityParser(FitMessages messages)
    {
        _messages = messages;
    }

    public List<SessionMessages> ParseSessions()
    {
        if (!IsActivityFile)
        {
            throw new Exception($"Expected FIT File Type: Activity, recieved File Type: {_firstFileIdMesg?.GetType()}");
        }

        // Create a read/write list of session messages
        var sessionMesgs = new List<SessionMesg>(_messages.SessionMesgs);

        // When there are no Sessions but there are Records create a Session message to recover as much data as possible
        if (sessionMesgs.Count == 0 && _messages.RecordMesgs.Count > 0)
        {
            Dynastream.Fit.DateTime startTime = _messages.RecordMesgs[0].GetTimestamp();
            Dynastream.Fit.DateTime timestamp = _messages.RecordMesgs[_messages.RecordMesgs.Count - 1].GetTimestamp();

            var session = new SessionMesg();
            session.SetStartTime(startTime);
            session.SetTimestamp(timestamp);
            session.SetTotalElapsedTime(timestamp.GetTimeStamp() - startTime.GetTimeStamp());
            session.SetTotalTimerTime(timestamp.GetTimeStamp() - startTime.GetTimeStamp());

            sessionMesgs.Add(session);
        }

        int recordsTaken = 0;

        var sessions = new List<SessionMessages>(sessionMesgs.Count);
        foreach (SessionMesg sessionMesg in sessionMesgs)
        {
            var session = new SessionMessages(sessionMesg)
            {
                Laps = _messages.LapMesgs.Skip(sessionMesg.GetFirstLapIndex() ?? 0).Take(sessionMesg.GetNumLaps() ?? 0).ToList(),

                ClimbPros = _messages.ClimbProMesgs.Where(climb => climb.Within(sessionMesg)).ToList(),
                Events = _messages.EventMesgs.Where(evt => evt.Within(sessionMesg)).ToList(),
                DeviceInfos = _messages.DeviceInfoMesgs.Where(deviceInfo => deviceInfo.Within(sessionMesg)).ToList(),
                Lengths = _messages.LengthMesgs.Where(length => length.Overlaps(sessionMesg)).ToList(),
                Records = _messages.RecordMesgs.Skip(recordsTaken).Where(record => record.Within(sessionMesg)).ToList(),
                SegmentLaps = _messages.SegmentLapMesgs.Where(segmentLap => segmentLap.Overlaps(sessionMesg)).ToList(),

                TimerEvents = _messages.EventMesgs.Where(evt => evt.GetEvent() == Event.Timer && evt.Within(sessionMesg)).ToList(),
                FrontGearChangeEvents = _messages.EventMesgs.Where(evt => evt.GetEvent() == Event.FrontGearChange && evt.Within(sessionMesg)).ToList(),
                RearGearChangeEvents = _messages.EventMesgs.Where(evt => evt.GetEvent() == Event.RearGearChange && evt.Within(sessionMesg)).ToList(),
                RiderPositionChangeEvents = _messages.EventMesgs.Where(evt => evt.GetEvent() == Event.RiderPositionChange && evt.Within(sessionMesg)).ToList(),

                FileId = _firstFileIdMesg,
                Activity = _activityMesg,
            };

            recordsTaken += session.Records.Count;
            sessions.Add(session);
        }

        return sessions;
    }

    public List<DeviceInfoMesg> DevicesWhereBatteryStatusIsLow()
    {
        var batteryStatus = new List<byte>() { BatteryStatus.Critical, BatteryStatus.Low };
        var deviceInfos = new List<DeviceInfoMesg>();

        deviceInfos = _messages.DeviceInfoMesgs.Where(info => batteryStatus.Contains(info.GetBatteryStatus() ?? BatteryStatus.Unknown)).ToList();
        return deviceInfos;
    }
}

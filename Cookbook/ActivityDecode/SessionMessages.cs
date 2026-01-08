/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using Dynastream.Fit;

public class SessionMessages
{
    public ActivityMesg Activity;
    public List<ClimbProMesg> ClimbPros = new List<ClimbProMesg>();
    public List<DeviceInfoMesg> DeviceInfos = new List<DeviceInfoMesg>();
    public List<EventMesg> Events = new List<EventMesg>();
    public FileIdMesg FileId;
    public List<LapMesg> Laps = new List<LapMesg>();
    public List<LengthMesg> Lengths = new List<LengthMesg>();
    public HashSet<string> RecordFieldNames = new HashSet<string>();
    public HashSet<string> RecordDeveloperFieldNames = new HashSet<string>();
    public List<SegmentLapMesg> SegmentLaps = new List<SegmentLapMesg>();
    public List<RecordMesg> Records = new List<RecordMesg>();
    public SessionMesg Session;

    public List<EventMesg> TimerEvents = new List<EventMesg>();
    public List<EventMesg> FrontGearChangeEvents = new List<EventMesg>();
    public List<EventMesg> RearGearChangeEvents = new List<EventMesg>();
    public List<EventMesg> RiderPositionChangeEvents = new List<EventMesg>();

    public SessionMessages(SessionMesg session)
    {
        Session = session;
    }
}
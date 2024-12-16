#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2024 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.158.0Release
// Tag = production/release/21.158.0-0-gc9428aa
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using Dynastream.Fit;

namespace Dynastream.Fit
{
    public class FitListener
    {
        public FitMessages FitMessages { get; private set; } = new FitMessages();

        public void OnMesg(object sender, MesgEventArgs e)
        {
            switch (e.mesg.Num)
            {
                case (ushort)MesgNum.FileId:
                    FitMessages.fileIdMesgs.Add(new FileIdMesg(e.mesg));
                    break;
                case (ushort)MesgNum.FileCreator:
                    FitMessages.fileCreatorMesgs.Add(new FileCreatorMesg(e.mesg));
                    break;
                case (ushort)MesgNum.TimestampCorrelation:
                    FitMessages.timestampCorrelationMesgs.Add(new TimestampCorrelationMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Software:
                    FitMessages.softwareMesgs.Add(new SoftwareMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SlaveDevice:
                    FitMessages.slaveDeviceMesgs.Add(new SlaveDeviceMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Capabilities:
                    FitMessages.capabilitiesMesgs.Add(new CapabilitiesMesg(e.mesg));
                    break;
                case (ushort)MesgNum.FileCapabilities:
                    FitMessages.fileCapabilitiesMesgs.Add(new FileCapabilitiesMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MesgCapabilities:
                    FitMessages.mesgCapabilitiesMesgs.Add(new MesgCapabilitiesMesg(e.mesg));
                    break;
                case (ushort)MesgNum.FieldCapabilities:
                    FitMessages.fieldCapabilitiesMesgs.Add(new FieldCapabilitiesMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DeviceSettings:
                    FitMessages.deviceSettingsMesgs.Add(new DeviceSettingsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.UserProfile:
                    FitMessages.userProfileMesgs.Add(new UserProfileMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HrmProfile:
                    FitMessages.hrmProfileMesgs.Add(new HrmProfileMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SdmProfile:
                    FitMessages.sdmProfileMesgs.Add(new SdmProfileMesg(e.mesg));
                    break;
                case (ushort)MesgNum.BikeProfile:
                    FitMessages.bikeProfileMesgs.Add(new BikeProfileMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Connectivity:
                    FitMessages.connectivityMesgs.Add(new ConnectivityMesg(e.mesg));
                    break;
                case (ushort)MesgNum.WatchfaceSettings:
                    FitMessages.watchfaceSettingsMesgs.Add(new WatchfaceSettingsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.OhrSettings:
                    FitMessages.ohrSettingsMesgs.Add(new OhrSettingsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.TimeInZone:
                    FitMessages.timeInZoneMesgs.Add(new TimeInZoneMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ZonesTarget:
                    FitMessages.zonesTargetMesgs.Add(new ZonesTargetMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Sport:
                    FitMessages.sportMesgs.Add(new SportMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HrZone:
                    FitMessages.hrZoneMesgs.Add(new HrZoneMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SpeedZone:
                    FitMessages.speedZoneMesgs.Add(new SpeedZoneMesg(e.mesg));
                    break;
                case (ushort)MesgNum.CadenceZone:
                    FitMessages.cadenceZoneMesgs.Add(new CadenceZoneMesg(e.mesg));
                    break;
                case (ushort)MesgNum.PowerZone:
                    FitMessages.powerZoneMesgs.Add(new PowerZoneMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MetZone:
                    FitMessages.metZoneMesgs.Add(new MetZoneMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DiveSettings:
                    FitMessages.diveSettingsMesgs.Add(new DiveSettingsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DiveAlarm:
                    FitMessages.diveAlarmMesgs.Add(new DiveAlarmMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DiveApneaAlarm:
                    FitMessages.diveApneaAlarmMesgs.Add(new DiveApneaAlarmMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DiveGas:
                    FitMessages.diveGasMesgs.Add(new DiveGasMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Goal:
                    FitMessages.goalMesgs.Add(new GoalMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Activity:
                    FitMessages.activityMesgs.Add(new ActivityMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Session:
                    FitMessages.sessionMesgs.Add(new SessionMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Lap:
                    FitMessages.lapMesgs.Add(new LapMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Length:
                    FitMessages.lengthMesgs.Add(new LengthMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Record:
                    FitMessages.recordMesgs.Add(new RecordMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Event:
                    FitMessages.eventMesgs.Add(new EventMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DeviceInfo:
                    FitMessages.deviceInfoMesgs.Add(new DeviceInfoMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DeviceAuxBatteryInfo:
                    FitMessages.deviceAuxBatteryInfoMesgs.Add(new DeviceAuxBatteryInfoMesg(e.mesg));
                    break;
                case (ushort)MesgNum.TrainingFile:
                    FitMessages.trainingFileMesgs.Add(new TrainingFileMesg(e.mesg));
                    break;
                case (ushort)MesgNum.WeatherConditions:
                    FitMessages.weatherConditionsMesgs.Add(new WeatherConditionsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.WeatherAlert:
                    FitMessages.weatherAlertMesgs.Add(new WeatherAlertMesg(e.mesg));
                    break;
                case (ushort)MesgNum.GpsMetadata:
                    FitMessages.gpsMetadataMesgs.Add(new GpsMetadataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.CameraEvent:
                    FitMessages.cameraEventMesgs.Add(new CameraEventMesg(e.mesg));
                    break;
                case (ushort)MesgNum.GyroscopeData:
                    FitMessages.gyroscopeDataMesgs.Add(new GyroscopeDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.AccelerometerData:
                    FitMessages.accelerometerDataMesgs.Add(new AccelerometerDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MagnetometerData:
                    FitMessages.magnetometerDataMesgs.Add(new MagnetometerDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.BarometerData:
                    FitMessages.barometerDataMesgs.Add(new BarometerDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ThreeDSensorCalibration:
                    FitMessages.threeDSensorCalibrationMesgs.Add(new ThreeDSensorCalibrationMesg(e.mesg));
                    break;
                case (ushort)MesgNum.OneDSensorCalibration:
                    FitMessages.oneDSensorCalibrationMesgs.Add(new OneDSensorCalibrationMesg(e.mesg));
                    break;
                case (ushort)MesgNum.VideoFrame:
                    FitMessages.videoFrameMesgs.Add(new VideoFrameMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ObdiiData:
                    FitMessages.obdiiDataMesgs.Add(new ObdiiDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.NmeaSentence:
                    FitMessages.nmeaSentenceMesgs.Add(new NmeaSentenceMesg(e.mesg));
                    break;
                case (ushort)MesgNum.AviationAttitude:
                    FitMessages.aviationAttitudeMesgs.Add(new AviationAttitudeMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Video:
                    FitMessages.videoMesgs.Add(new VideoMesg(e.mesg));
                    break;
                case (ushort)MesgNum.VideoTitle:
                    FitMessages.videoTitleMesgs.Add(new VideoTitleMesg(e.mesg));
                    break;
                case (ushort)MesgNum.VideoDescription:
                    FitMessages.videoDescriptionMesgs.Add(new VideoDescriptionMesg(e.mesg));
                    break;
                case (ushort)MesgNum.VideoClip:
                    FitMessages.videoClipMesgs.Add(new VideoClipMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Set:
                    FitMessages.setMesgs.Add(new SetMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Jump:
                    FitMessages.jumpMesgs.Add(new JumpMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Split:
                    FitMessages.splitMesgs.Add(new SplitMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SplitSummary:
                    FitMessages.splitSummaryMesgs.Add(new SplitSummaryMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ClimbPro:
                    FitMessages.climbProMesgs.Add(new ClimbProMesg(e.mesg));
                    break;
                case (ushort)MesgNum.FieldDescription:
                    FitMessages.fieldDescriptionMesgs.Add(new FieldDescriptionMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DeveloperDataId:
                    FitMessages.developerDataIdMesgs.Add(new DeveloperDataIdMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Course:
                    FitMessages.courseMesgs.Add(new CourseMesg(e.mesg));
                    break;
                case (ushort)MesgNum.CoursePoint:
                    FitMessages.coursePointMesgs.Add(new CoursePointMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SegmentId:
                    FitMessages.segmentIdMesgs.Add(new SegmentIdMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SegmentLeaderboardEntry:
                    FitMessages.segmentLeaderboardEntryMesgs.Add(new SegmentLeaderboardEntryMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SegmentPoint:
                    FitMessages.segmentPointMesgs.Add(new SegmentPointMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SegmentLap:
                    FitMessages.segmentLapMesgs.Add(new SegmentLapMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SegmentFile:
                    FitMessages.segmentFileMesgs.Add(new SegmentFileMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Workout:
                    FitMessages.workoutMesgs.Add(new WorkoutMesg(e.mesg));
                    break;
                case (ushort)MesgNum.WorkoutSession:
                    FitMessages.workoutSessionMesgs.Add(new WorkoutSessionMesg(e.mesg));
                    break;
                case (ushort)MesgNum.WorkoutStep:
                    FitMessages.workoutStepMesgs.Add(new WorkoutStepMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ExerciseTitle:
                    FitMessages.exerciseTitleMesgs.Add(new ExerciseTitleMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Schedule:
                    FitMessages.scheduleMesgs.Add(new ScheduleMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Totals:
                    FitMessages.totalsMesgs.Add(new TotalsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.WeightScale:
                    FitMessages.weightScaleMesgs.Add(new WeightScaleMesg(e.mesg));
                    break;
                case (ushort)MesgNum.BloodPressure:
                    FitMessages.bloodPressureMesgs.Add(new BloodPressureMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MonitoringInfo:
                    FitMessages.monitoringInfoMesgs.Add(new MonitoringInfoMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Monitoring:
                    FitMessages.monitoringMesgs.Add(new MonitoringMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MonitoringHrData:
                    FitMessages.monitoringHrDataMesgs.Add(new MonitoringHrDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Spo2Data:
                    FitMessages.spo2DataMesgs.Add(new Spo2DataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Hr:
                    FitMessages.hrMesgs.Add(new HrMesg(e.mesg));
                    break;
                case (ushort)MesgNum.StressLevel:
                    FitMessages.stressLevelMesgs.Add(new StressLevelMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MaxMetData:
                    FitMessages.maxMetDataMesgs.Add(new MaxMetDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaBodyBatteryData:
                    FitMessages.hsaBodyBatteryDataMesgs.Add(new HsaBodyBatteryDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaEvent:
                    FitMessages.hsaEventMesgs.Add(new HsaEventMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaAccelerometerData:
                    FitMessages.hsaAccelerometerDataMesgs.Add(new HsaAccelerometerDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaGyroscopeData:
                    FitMessages.hsaGyroscopeDataMesgs.Add(new HsaGyroscopeDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaStepData:
                    FitMessages.hsaStepDataMesgs.Add(new HsaStepDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaSpo2Data:
                    FitMessages.hsaSpo2DataMesgs.Add(new HsaSpo2DataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaStressData:
                    FitMessages.hsaStressDataMesgs.Add(new HsaStressDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaRespirationData:
                    FitMessages.hsaRespirationDataMesgs.Add(new HsaRespirationDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaHeartRateData:
                    FitMessages.hsaHeartRateDataMesgs.Add(new HsaHeartRateDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaConfigurationData:
                    FitMessages.hsaConfigurationDataMesgs.Add(new HsaConfigurationDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HsaWristTemperatureData:
                    FitMessages.hsaWristTemperatureDataMesgs.Add(new HsaWristTemperatureDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.MemoGlob:
                    FitMessages.memoGlobMesgs.Add(new MemoGlobMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SleepLevel:
                    FitMessages.sleepLevelMesgs.Add(new SleepLevelMesg(e.mesg));
                    break;
                case (ushort)MesgNum.AntChannelId:
                    FitMessages.antChannelIdMesgs.Add(new AntChannelIdMesg(e.mesg));
                    break;
                case (ushort)MesgNum.AntRx:
                    FitMessages.antRxMesgs.Add(new AntRxMesg(e.mesg));
                    break;
                case (ushort)MesgNum.AntTx:
                    FitMessages.antTxMesgs.Add(new AntTxMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ExdScreenConfiguration:
                    FitMessages.exdScreenConfigurationMesgs.Add(new ExdScreenConfigurationMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ExdDataFieldConfiguration:
                    FitMessages.exdDataFieldConfigurationMesgs.Add(new ExdDataFieldConfigurationMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ExdDataConceptConfiguration:
                    FitMessages.exdDataConceptConfigurationMesgs.Add(new ExdDataConceptConfigurationMesg(e.mesg));
                    break;
                case (ushort)MesgNum.DiveSummary:
                    FitMessages.diveSummaryMesgs.Add(new DiveSummaryMesg(e.mesg));
                    break;
                case (ushort)MesgNum.AadAccelFeatures:
                    FitMessages.aadAccelFeaturesMesgs.Add(new AadAccelFeaturesMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Hrv:
                    FitMessages.hrvMesgs.Add(new HrvMesg(e.mesg));
                    break;
                case (ushort)MesgNum.BeatIntervals:
                    FitMessages.beatIntervalsMesgs.Add(new BeatIntervalsMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HrvStatusSummary:
                    FitMessages.hrvStatusSummaryMesgs.Add(new HrvStatusSummaryMesg(e.mesg));
                    break;
                case (ushort)MesgNum.HrvValue:
                    FitMessages.hrvValueMesgs.Add(new HrvValueMesg(e.mesg));
                    break;
                case (ushort)MesgNum.RawBbi:
                    FitMessages.rawBbiMesgs.Add(new RawBbiMesg(e.mesg));
                    break;
                case (ushort)MesgNum.RespirationRate:
                    FitMessages.respirationRateMesgs.Add(new RespirationRateMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ChronoShotSession:
                    FitMessages.chronoShotSessionMesgs.Add(new ChronoShotSessionMesg(e.mesg));
                    break;
                case (ushort)MesgNum.ChronoShotData:
                    FitMessages.chronoShotDataMesgs.Add(new ChronoShotDataMesg(e.mesg));
                    break;
                case (ushort)MesgNum.TankUpdate:
                    FitMessages.tankUpdateMesgs.Add(new TankUpdateMesg(e.mesg));
                    break;
                case (ushort)MesgNum.TankSummary:
                    FitMessages.tankSummaryMesgs.Add(new TankSummaryMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SleepAssessment:
                    FitMessages.sleepAssessmentMesgs.Add(new SleepAssessmentMesg(e.mesg));
                    break;
                case (ushort)MesgNum.SkinTempOvernight:
                    FitMessages.skinTempOvernightMesgs.Add(new SkinTempOvernightMesg(e.mesg));
                    break;
                case (ushort)MesgNum.Pad:
                    FitMessages.padMesgs.Add(new PadMesg(e.mesg));
                    break;
            }
        }
    }
}

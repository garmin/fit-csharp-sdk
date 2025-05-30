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

using Dynastream.Fit;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dynastream.Fit
{
    public class FitMessages
    {
        public FitMessages() { }
        
        protected internal List<FileIdMesg> fileIdMesgs = new List<FileIdMesg>();
        protected internal List<FileCreatorMesg> fileCreatorMesgs = new List<FileCreatorMesg>();
        protected internal List<TimestampCorrelationMesg> timestampCorrelationMesgs = new List<TimestampCorrelationMesg>();
        protected internal List<SoftwareMesg> softwareMesgs = new List<SoftwareMesg>();
        protected internal List<SlaveDeviceMesg> slaveDeviceMesgs = new List<SlaveDeviceMesg>();
        protected internal List<CapabilitiesMesg> capabilitiesMesgs = new List<CapabilitiesMesg>();
        protected internal List<FileCapabilitiesMesg> fileCapabilitiesMesgs = new List<FileCapabilitiesMesg>();
        protected internal List<MesgCapabilitiesMesg> mesgCapabilitiesMesgs = new List<MesgCapabilitiesMesg>();
        protected internal List<FieldCapabilitiesMesg> fieldCapabilitiesMesgs = new List<FieldCapabilitiesMesg>();
        protected internal List<DeviceSettingsMesg> deviceSettingsMesgs = new List<DeviceSettingsMesg>();
        protected internal List<UserProfileMesg> userProfileMesgs = new List<UserProfileMesg>();
        protected internal List<HrmProfileMesg> hrmProfileMesgs = new List<HrmProfileMesg>();
        protected internal List<SdmProfileMesg> sdmProfileMesgs = new List<SdmProfileMesg>();
        protected internal List<BikeProfileMesg> bikeProfileMesgs = new List<BikeProfileMesg>();
        protected internal List<ConnectivityMesg> connectivityMesgs = new List<ConnectivityMesg>();
        protected internal List<WatchfaceSettingsMesg> watchfaceSettingsMesgs = new List<WatchfaceSettingsMesg>();
        protected internal List<OhrSettingsMesg> ohrSettingsMesgs = new List<OhrSettingsMesg>();
        protected internal List<TimeInZoneMesg> timeInZoneMesgs = new List<TimeInZoneMesg>();
        protected internal List<ZonesTargetMesg> zonesTargetMesgs = new List<ZonesTargetMesg>();
        protected internal List<SportMesg> sportMesgs = new List<SportMesg>();
        protected internal List<HrZoneMesg> hrZoneMesgs = new List<HrZoneMesg>();
        protected internal List<SpeedZoneMesg> speedZoneMesgs = new List<SpeedZoneMesg>();
        protected internal List<CadenceZoneMesg> cadenceZoneMesgs = new List<CadenceZoneMesg>();
        protected internal List<PowerZoneMesg> powerZoneMesgs = new List<PowerZoneMesg>();
        protected internal List<MetZoneMesg> metZoneMesgs = new List<MetZoneMesg>();
        protected internal List<TrainingSettingsMesg> trainingSettingsMesgs = new List<TrainingSettingsMesg>();
        protected internal List<DiveSettingsMesg> diveSettingsMesgs = new List<DiveSettingsMesg>();
        protected internal List<DiveAlarmMesg> diveAlarmMesgs = new List<DiveAlarmMesg>();
        protected internal List<DiveApneaAlarmMesg> diveApneaAlarmMesgs = new List<DiveApneaAlarmMesg>();
        protected internal List<DiveGasMesg> diveGasMesgs = new List<DiveGasMesg>();
        protected internal List<GoalMesg> goalMesgs = new List<GoalMesg>();
        protected internal List<ActivityMesg> activityMesgs = new List<ActivityMesg>();
        protected internal List<SessionMesg> sessionMesgs = new List<SessionMesg>();
        protected internal List<LapMesg> lapMesgs = new List<LapMesg>();
        protected internal List<LengthMesg> lengthMesgs = new List<LengthMesg>();
        protected internal List<RecordMesg> recordMesgs = new List<RecordMesg>();
        protected internal List<EventMesg> eventMesgs = new List<EventMesg>();
        protected internal List<DeviceInfoMesg> deviceInfoMesgs = new List<DeviceInfoMesg>();
        protected internal List<DeviceAuxBatteryInfoMesg> deviceAuxBatteryInfoMesgs = new List<DeviceAuxBatteryInfoMesg>();
        protected internal List<TrainingFileMesg> trainingFileMesgs = new List<TrainingFileMesg>();
        protected internal List<WeatherConditionsMesg> weatherConditionsMesgs = new List<WeatherConditionsMesg>();
        protected internal List<WeatherAlertMesg> weatherAlertMesgs = new List<WeatherAlertMesg>();
        protected internal List<GpsMetadataMesg> gpsMetadataMesgs = new List<GpsMetadataMesg>();
        protected internal List<CameraEventMesg> cameraEventMesgs = new List<CameraEventMesg>();
        protected internal List<GyroscopeDataMesg> gyroscopeDataMesgs = new List<GyroscopeDataMesg>();
        protected internal List<AccelerometerDataMesg> accelerometerDataMesgs = new List<AccelerometerDataMesg>();
        protected internal List<MagnetometerDataMesg> magnetometerDataMesgs = new List<MagnetometerDataMesg>();
        protected internal List<BarometerDataMesg> barometerDataMesgs = new List<BarometerDataMesg>();
        protected internal List<ThreeDSensorCalibrationMesg> threeDSensorCalibrationMesgs = new List<ThreeDSensorCalibrationMesg>();
        protected internal List<OneDSensorCalibrationMesg> oneDSensorCalibrationMesgs = new List<OneDSensorCalibrationMesg>();
        protected internal List<VideoFrameMesg> videoFrameMesgs = new List<VideoFrameMesg>();
        protected internal List<ObdiiDataMesg> obdiiDataMesgs = new List<ObdiiDataMesg>();
        protected internal List<NmeaSentenceMesg> nmeaSentenceMesgs = new List<NmeaSentenceMesg>();
        protected internal List<AviationAttitudeMesg> aviationAttitudeMesgs = new List<AviationAttitudeMesg>();
        protected internal List<VideoMesg> videoMesgs = new List<VideoMesg>();
        protected internal List<VideoTitleMesg> videoTitleMesgs = new List<VideoTitleMesg>();
        protected internal List<VideoDescriptionMesg> videoDescriptionMesgs = new List<VideoDescriptionMesg>();
        protected internal List<VideoClipMesg> videoClipMesgs = new List<VideoClipMesg>();
        protected internal List<SetMesg> setMesgs = new List<SetMesg>();
        protected internal List<JumpMesg> jumpMesgs = new List<JumpMesg>();
        protected internal List<SplitMesg> splitMesgs = new List<SplitMesg>();
        protected internal List<SplitSummaryMesg> splitSummaryMesgs = new List<SplitSummaryMesg>();
        protected internal List<ClimbProMesg> climbProMesgs = new List<ClimbProMesg>();
        protected internal List<FieldDescriptionMesg> fieldDescriptionMesgs = new List<FieldDescriptionMesg>();
        protected internal List<DeveloperDataIdMesg> developerDataIdMesgs = new List<DeveloperDataIdMesg>();
        protected internal List<CourseMesg> courseMesgs = new List<CourseMesg>();
        protected internal List<CoursePointMesg> coursePointMesgs = new List<CoursePointMesg>();
        protected internal List<SegmentIdMesg> segmentIdMesgs = new List<SegmentIdMesg>();
        protected internal List<SegmentLeaderboardEntryMesg> segmentLeaderboardEntryMesgs = new List<SegmentLeaderboardEntryMesg>();
        protected internal List<SegmentPointMesg> segmentPointMesgs = new List<SegmentPointMesg>();
        protected internal List<SegmentLapMesg> segmentLapMesgs = new List<SegmentLapMesg>();
        protected internal List<SegmentFileMesg> segmentFileMesgs = new List<SegmentFileMesg>();
        protected internal List<WorkoutMesg> workoutMesgs = new List<WorkoutMesg>();
        protected internal List<WorkoutSessionMesg> workoutSessionMesgs = new List<WorkoutSessionMesg>();
        protected internal List<WorkoutStepMesg> workoutStepMesgs = new List<WorkoutStepMesg>();
        protected internal List<ExerciseTitleMesg> exerciseTitleMesgs = new List<ExerciseTitleMesg>();
        protected internal List<ScheduleMesg> scheduleMesgs = new List<ScheduleMesg>();
        protected internal List<TotalsMesg> totalsMesgs = new List<TotalsMesg>();
        protected internal List<WeightScaleMesg> weightScaleMesgs = new List<WeightScaleMesg>();
        protected internal List<BloodPressureMesg> bloodPressureMesgs = new List<BloodPressureMesg>();
        protected internal List<MonitoringInfoMesg> monitoringInfoMesgs = new List<MonitoringInfoMesg>();
        protected internal List<MonitoringMesg> monitoringMesgs = new List<MonitoringMesg>();
        protected internal List<MonitoringHrDataMesg> monitoringHrDataMesgs = new List<MonitoringHrDataMesg>();
        protected internal List<Spo2DataMesg> spo2DataMesgs = new List<Spo2DataMesg>();
        protected internal List<HrMesg> hrMesgs = new List<HrMesg>();
        protected internal List<StressLevelMesg> stressLevelMesgs = new List<StressLevelMesg>();
        protected internal List<MaxMetDataMesg> maxMetDataMesgs = new List<MaxMetDataMesg>();
        protected internal List<HsaBodyBatteryDataMesg> hsaBodyBatteryDataMesgs = new List<HsaBodyBatteryDataMesg>();
        protected internal List<HsaEventMesg> hsaEventMesgs = new List<HsaEventMesg>();
        protected internal List<HsaAccelerometerDataMesg> hsaAccelerometerDataMesgs = new List<HsaAccelerometerDataMesg>();
        protected internal List<HsaGyroscopeDataMesg> hsaGyroscopeDataMesgs = new List<HsaGyroscopeDataMesg>();
        protected internal List<HsaStepDataMesg> hsaStepDataMesgs = new List<HsaStepDataMesg>();
        protected internal List<HsaSpo2DataMesg> hsaSpo2DataMesgs = new List<HsaSpo2DataMesg>();
        protected internal List<HsaStressDataMesg> hsaStressDataMesgs = new List<HsaStressDataMesg>();
        protected internal List<HsaRespirationDataMesg> hsaRespirationDataMesgs = new List<HsaRespirationDataMesg>();
        protected internal List<HsaHeartRateDataMesg> hsaHeartRateDataMesgs = new List<HsaHeartRateDataMesg>();
        protected internal List<HsaConfigurationDataMesg> hsaConfigurationDataMesgs = new List<HsaConfigurationDataMesg>();
        protected internal List<HsaWristTemperatureDataMesg> hsaWristTemperatureDataMesgs = new List<HsaWristTemperatureDataMesg>();
        protected internal List<MemoGlobMesg> memoGlobMesgs = new List<MemoGlobMesg>();
        protected internal List<SleepLevelMesg> sleepLevelMesgs = new List<SleepLevelMesg>();
        protected internal List<AntChannelIdMesg> antChannelIdMesgs = new List<AntChannelIdMesg>();
        protected internal List<AntRxMesg> antRxMesgs = new List<AntRxMesg>();
        protected internal List<AntTxMesg> antTxMesgs = new List<AntTxMesg>();
        protected internal List<ExdScreenConfigurationMesg> exdScreenConfigurationMesgs = new List<ExdScreenConfigurationMesg>();
        protected internal List<ExdDataFieldConfigurationMesg> exdDataFieldConfigurationMesgs = new List<ExdDataFieldConfigurationMesg>();
        protected internal List<ExdDataConceptConfigurationMesg> exdDataConceptConfigurationMesgs = new List<ExdDataConceptConfigurationMesg>();
        protected internal List<DiveSummaryMesg> diveSummaryMesgs = new List<DiveSummaryMesg>();
        protected internal List<AadAccelFeaturesMesg> aadAccelFeaturesMesgs = new List<AadAccelFeaturesMesg>();
        protected internal List<HrvMesg> hrvMesgs = new List<HrvMesg>();
        protected internal List<BeatIntervalsMesg> beatIntervalsMesgs = new List<BeatIntervalsMesg>();
        protected internal List<HrvStatusSummaryMesg> hrvStatusSummaryMesgs = new List<HrvStatusSummaryMesg>();
        protected internal List<HrvValueMesg> hrvValueMesgs = new List<HrvValueMesg>();
        protected internal List<RawBbiMesg> rawBbiMesgs = new List<RawBbiMesg>();
        protected internal List<RespirationRateMesg> respirationRateMesgs = new List<RespirationRateMesg>();
        protected internal List<ChronoShotSessionMesg> chronoShotSessionMesgs = new List<ChronoShotSessionMesg>();
        protected internal List<ChronoShotDataMesg> chronoShotDataMesgs = new List<ChronoShotDataMesg>();
        protected internal List<TankUpdateMesg> tankUpdateMesgs = new List<TankUpdateMesg>();
        protected internal List<TankSummaryMesg> tankSummaryMesgs = new List<TankSummaryMesg>();
        protected internal List<SleepAssessmentMesg> sleepAssessmentMesgs = new List<SleepAssessmentMesg>();
        protected internal List<SkinTempOvernightMesg> skinTempOvernightMesgs = new List<SkinTempOvernightMesg>();
        protected internal List<PadMesg> padMesgs = new List<PadMesg>();

        
        public ReadOnlyCollection<FileIdMesg> FileIdMesgs => new ReadOnlyCollection<FileIdMesg>(fileIdMesgs);
        public ReadOnlyCollection<FileCreatorMesg> FileCreatorMesgs => new ReadOnlyCollection<FileCreatorMesg>(fileCreatorMesgs);
        public ReadOnlyCollection<TimestampCorrelationMesg> TimestampCorrelationMesgs => new ReadOnlyCollection<TimestampCorrelationMesg>(timestampCorrelationMesgs);
        public ReadOnlyCollection<SoftwareMesg> SoftwareMesgs => new ReadOnlyCollection<SoftwareMesg>(softwareMesgs);
        public ReadOnlyCollection<SlaveDeviceMesg> SlaveDeviceMesgs => new ReadOnlyCollection<SlaveDeviceMesg>(slaveDeviceMesgs);
        public ReadOnlyCollection<CapabilitiesMesg> CapabilitiesMesgs => new ReadOnlyCollection<CapabilitiesMesg>(capabilitiesMesgs);
        public ReadOnlyCollection<FileCapabilitiesMesg> FileCapabilitiesMesgs => new ReadOnlyCollection<FileCapabilitiesMesg>(fileCapabilitiesMesgs);
        public ReadOnlyCollection<MesgCapabilitiesMesg> MesgCapabilitiesMesgs => new ReadOnlyCollection<MesgCapabilitiesMesg>(mesgCapabilitiesMesgs);
        public ReadOnlyCollection<FieldCapabilitiesMesg> FieldCapabilitiesMesgs => new ReadOnlyCollection<FieldCapabilitiesMesg>(fieldCapabilitiesMesgs);
        public ReadOnlyCollection<DeviceSettingsMesg> DeviceSettingsMesgs => new ReadOnlyCollection<DeviceSettingsMesg>(deviceSettingsMesgs);
        public ReadOnlyCollection<UserProfileMesg> UserProfileMesgs => new ReadOnlyCollection<UserProfileMesg>(userProfileMesgs);
        public ReadOnlyCollection<HrmProfileMesg> HrmProfileMesgs => new ReadOnlyCollection<HrmProfileMesg>(hrmProfileMesgs);
        public ReadOnlyCollection<SdmProfileMesg> SdmProfileMesgs => new ReadOnlyCollection<SdmProfileMesg>(sdmProfileMesgs);
        public ReadOnlyCollection<BikeProfileMesg> BikeProfileMesgs => new ReadOnlyCollection<BikeProfileMesg>(bikeProfileMesgs);
        public ReadOnlyCollection<ConnectivityMesg> ConnectivityMesgs => new ReadOnlyCollection<ConnectivityMesg>(connectivityMesgs);
        public ReadOnlyCollection<WatchfaceSettingsMesg> WatchfaceSettingsMesgs => new ReadOnlyCollection<WatchfaceSettingsMesg>(watchfaceSettingsMesgs);
        public ReadOnlyCollection<OhrSettingsMesg> OhrSettingsMesgs => new ReadOnlyCollection<OhrSettingsMesg>(ohrSettingsMesgs);
        public ReadOnlyCollection<TimeInZoneMesg> TimeInZoneMesgs => new ReadOnlyCollection<TimeInZoneMesg>(timeInZoneMesgs);
        public ReadOnlyCollection<ZonesTargetMesg> ZonesTargetMesgs => new ReadOnlyCollection<ZonesTargetMesg>(zonesTargetMesgs);
        public ReadOnlyCollection<SportMesg> SportMesgs => new ReadOnlyCollection<SportMesg>(sportMesgs);
        public ReadOnlyCollection<HrZoneMesg> HrZoneMesgs => new ReadOnlyCollection<HrZoneMesg>(hrZoneMesgs);
        public ReadOnlyCollection<SpeedZoneMesg> SpeedZoneMesgs => new ReadOnlyCollection<SpeedZoneMesg>(speedZoneMesgs);
        public ReadOnlyCollection<CadenceZoneMesg> CadenceZoneMesgs => new ReadOnlyCollection<CadenceZoneMesg>(cadenceZoneMesgs);
        public ReadOnlyCollection<PowerZoneMesg> PowerZoneMesgs => new ReadOnlyCollection<PowerZoneMesg>(powerZoneMesgs);
        public ReadOnlyCollection<MetZoneMesg> MetZoneMesgs => new ReadOnlyCollection<MetZoneMesg>(metZoneMesgs);
        public ReadOnlyCollection<TrainingSettingsMesg> TrainingSettingsMesgs => new ReadOnlyCollection<TrainingSettingsMesg>(trainingSettingsMesgs);
        public ReadOnlyCollection<DiveSettingsMesg> DiveSettingsMesgs => new ReadOnlyCollection<DiveSettingsMesg>(diveSettingsMesgs);
        public ReadOnlyCollection<DiveAlarmMesg> DiveAlarmMesgs => new ReadOnlyCollection<DiveAlarmMesg>(diveAlarmMesgs);
        public ReadOnlyCollection<DiveApneaAlarmMesg> DiveApneaAlarmMesgs => new ReadOnlyCollection<DiveApneaAlarmMesg>(diveApneaAlarmMesgs);
        public ReadOnlyCollection<DiveGasMesg> DiveGasMesgs => new ReadOnlyCollection<DiveGasMesg>(diveGasMesgs);
        public ReadOnlyCollection<GoalMesg> GoalMesgs => new ReadOnlyCollection<GoalMesg>(goalMesgs);
        public ReadOnlyCollection<ActivityMesg> ActivityMesgs => new ReadOnlyCollection<ActivityMesg>(activityMesgs);
        public ReadOnlyCollection<SessionMesg> SessionMesgs => new ReadOnlyCollection<SessionMesg>(sessionMesgs);
        public ReadOnlyCollection<LapMesg> LapMesgs => new ReadOnlyCollection<LapMesg>(lapMesgs);
        public ReadOnlyCollection<LengthMesg> LengthMesgs => new ReadOnlyCollection<LengthMesg>(lengthMesgs);
        public ReadOnlyCollection<RecordMesg> RecordMesgs => new ReadOnlyCollection<RecordMesg>(recordMesgs);
        public ReadOnlyCollection<EventMesg> EventMesgs => new ReadOnlyCollection<EventMesg>(eventMesgs);
        public ReadOnlyCollection<DeviceInfoMesg> DeviceInfoMesgs => new ReadOnlyCollection<DeviceInfoMesg>(deviceInfoMesgs);
        public ReadOnlyCollection<DeviceAuxBatteryInfoMesg> DeviceAuxBatteryInfoMesgs => new ReadOnlyCollection<DeviceAuxBatteryInfoMesg>(deviceAuxBatteryInfoMesgs);
        public ReadOnlyCollection<TrainingFileMesg> TrainingFileMesgs => new ReadOnlyCollection<TrainingFileMesg>(trainingFileMesgs);
        public ReadOnlyCollection<WeatherConditionsMesg> WeatherConditionsMesgs => new ReadOnlyCollection<WeatherConditionsMesg>(weatherConditionsMesgs);
        public ReadOnlyCollection<WeatherAlertMesg> WeatherAlertMesgs => new ReadOnlyCollection<WeatherAlertMesg>(weatherAlertMesgs);
        public ReadOnlyCollection<GpsMetadataMesg> GpsMetadataMesgs => new ReadOnlyCollection<GpsMetadataMesg>(gpsMetadataMesgs);
        public ReadOnlyCollection<CameraEventMesg> CameraEventMesgs => new ReadOnlyCollection<CameraEventMesg>(cameraEventMesgs);
        public ReadOnlyCollection<GyroscopeDataMesg> GyroscopeDataMesgs => new ReadOnlyCollection<GyroscopeDataMesg>(gyroscopeDataMesgs);
        public ReadOnlyCollection<AccelerometerDataMesg> AccelerometerDataMesgs => new ReadOnlyCollection<AccelerometerDataMesg>(accelerometerDataMesgs);
        public ReadOnlyCollection<MagnetometerDataMesg> MagnetometerDataMesgs => new ReadOnlyCollection<MagnetometerDataMesg>(magnetometerDataMesgs);
        public ReadOnlyCollection<BarometerDataMesg> BarometerDataMesgs => new ReadOnlyCollection<BarometerDataMesg>(barometerDataMesgs);
        public ReadOnlyCollection<ThreeDSensorCalibrationMesg> ThreeDSensorCalibrationMesgs => new ReadOnlyCollection<ThreeDSensorCalibrationMesg>(threeDSensorCalibrationMesgs);
        public ReadOnlyCollection<OneDSensorCalibrationMesg> OneDSensorCalibrationMesgs => new ReadOnlyCollection<OneDSensorCalibrationMesg>(oneDSensorCalibrationMesgs);
        public ReadOnlyCollection<VideoFrameMesg> VideoFrameMesgs => new ReadOnlyCollection<VideoFrameMesg>(videoFrameMesgs);
        public ReadOnlyCollection<ObdiiDataMesg> ObdiiDataMesgs => new ReadOnlyCollection<ObdiiDataMesg>(obdiiDataMesgs);
        public ReadOnlyCollection<NmeaSentenceMesg> NmeaSentenceMesgs => new ReadOnlyCollection<NmeaSentenceMesg>(nmeaSentenceMesgs);
        public ReadOnlyCollection<AviationAttitudeMesg> AviationAttitudeMesgs => new ReadOnlyCollection<AviationAttitudeMesg>(aviationAttitudeMesgs);
        public ReadOnlyCollection<VideoMesg> VideoMesgs => new ReadOnlyCollection<VideoMesg>(videoMesgs);
        public ReadOnlyCollection<VideoTitleMesg> VideoTitleMesgs => new ReadOnlyCollection<VideoTitleMesg>(videoTitleMesgs);
        public ReadOnlyCollection<VideoDescriptionMesg> VideoDescriptionMesgs => new ReadOnlyCollection<VideoDescriptionMesg>(videoDescriptionMesgs);
        public ReadOnlyCollection<VideoClipMesg> VideoClipMesgs => new ReadOnlyCollection<VideoClipMesg>(videoClipMesgs);
        public ReadOnlyCollection<SetMesg> SetMesgs => new ReadOnlyCollection<SetMesg>(setMesgs);
        public ReadOnlyCollection<JumpMesg> JumpMesgs => new ReadOnlyCollection<JumpMesg>(jumpMesgs);
        public ReadOnlyCollection<SplitMesg> SplitMesgs => new ReadOnlyCollection<SplitMesg>(splitMesgs);
        public ReadOnlyCollection<SplitSummaryMesg> SplitSummaryMesgs => new ReadOnlyCollection<SplitSummaryMesg>(splitSummaryMesgs);
        public ReadOnlyCollection<ClimbProMesg> ClimbProMesgs => new ReadOnlyCollection<ClimbProMesg>(climbProMesgs);
        public ReadOnlyCollection<FieldDescriptionMesg> FieldDescriptionMesgs => new ReadOnlyCollection<FieldDescriptionMesg>(fieldDescriptionMesgs);
        public ReadOnlyCollection<DeveloperDataIdMesg> DeveloperDataIdMesgs => new ReadOnlyCollection<DeveloperDataIdMesg>(developerDataIdMesgs);
        public ReadOnlyCollection<CourseMesg> CourseMesgs => new ReadOnlyCollection<CourseMesg>(courseMesgs);
        public ReadOnlyCollection<CoursePointMesg> CoursePointMesgs => new ReadOnlyCollection<CoursePointMesg>(coursePointMesgs);
        public ReadOnlyCollection<SegmentIdMesg> SegmentIdMesgs => new ReadOnlyCollection<SegmentIdMesg>(segmentIdMesgs);
        public ReadOnlyCollection<SegmentLeaderboardEntryMesg> SegmentLeaderboardEntryMesgs => new ReadOnlyCollection<SegmentLeaderboardEntryMesg>(segmentLeaderboardEntryMesgs);
        public ReadOnlyCollection<SegmentPointMesg> SegmentPointMesgs => new ReadOnlyCollection<SegmentPointMesg>(segmentPointMesgs);
        public ReadOnlyCollection<SegmentLapMesg> SegmentLapMesgs => new ReadOnlyCollection<SegmentLapMesg>(segmentLapMesgs);
        public ReadOnlyCollection<SegmentFileMesg> SegmentFileMesgs => new ReadOnlyCollection<SegmentFileMesg>(segmentFileMesgs);
        public ReadOnlyCollection<WorkoutMesg> WorkoutMesgs => new ReadOnlyCollection<WorkoutMesg>(workoutMesgs);
        public ReadOnlyCollection<WorkoutSessionMesg> WorkoutSessionMesgs => new ReadOnlyCollection<WorkoutSessionMesg>(workoutSessionMesgs);
        public ReadOnlyCollection<WorkoutStepMesg> WorkoutStepMesgs => new ReadOnlyCollection<WorkoutStepMesg>(workoutStepMesgs);
        public ReadOnlyCollection<ExerciseTitleMesg> ExerciseTitleMesgs => new ReadOnlyCollection<ExerciseTitleMesg>(exerciseTitleMesgs);
        public ReadOnlyCollection<ScheduleMesg> ScheduleMesgs => new ReadOnlyCollection<ScheduleMesg>(scheduleMesgs);
        public ReadOnlyCollection<TotalsMesg> TotalsMesgs => new ReadOnlyCollection<TotalsMesg>(totalsMesgs);
        public ReadOnlyCollection<WeightScaleMesg> WeightScaleMesgs => new ReadOnlyCollection<WeightScaleMesg>(weightScaleMesgs);
        public ReadOnlyCollection<BloodPressureMesg> BloodPressureMesgs => new ReadOnlyCollection<BloodPressureMesg>(bloodPressureMesgs);
        public ReadOnlyCollection<MonitoringInfoMesg> MonitoringInfoMesgs => new ReadOnlyCollection<MonitoringInfoMesg>(monitoringInfoMesgs);
        public ReadOnlyCollection<MonitoringMesg> MonitoringMesgs => new ReadOnlyCollection<MonitoringMesg>(monitoringMesgs);
        public ReadOnlyCollection<MonitoringHrDataMesg> MonitoringHrDataMesgs => new ReadOnlyCollection<MonitoringHrDataMesg>(monitoringHrDataMesgs);
        public ReadOnlyCollection<Spo2DataMesg> Spo2DataMesgs => new ReadOnlyCollection<Spo2DataMesg>(spo2DataMesgs);
        public ReadOnlyCollection<HrMesg> HrMesgs => new ReadOnlyCollection<HrMesg>(hrMesgs);
        public ReadOnlyCollection<StressLevelMesg> StressLevelMesgs => new ReadOnlyCollection<StressLevelMesg>(stressLevelMesgs);
        public ReadOnlyCollection<MaxMetDataMesg> MaxMetDataMesgs => new ReadOnlyCollection<MaxMetDataMesg>(maxMetDataMesgs);
        public ReadOnlyCollection<HsaBodyBatteryDataMesg> HsaBodyBatteryDataMesgs => new ReadOnlyCollection<HsaBodyBatteryDataMesg>(hsaBodyBatteryDataMesgs);
        public ReadOnlyCollection<HsaEventMesg> HsaEventMesgs => new ReadOnlyCollection<HsaEventMesg>(hsaEventMesgs);
        public ReadOnlyCollection<HsaAccelerometerDataMesg> HsaAccelerometerDataMesgs => new ReadOnlyCollection<HsaAccelerometerDataMesg>(hsaAccelerometerDataMesgs);
        public ReadOnlyCollection<HsaGyroscopeDataMesg> HsaGyroscopeDataMesgs => new ReadOnlyCollection<HsaGyroscopeDataMesg>(hsaGyroscopeDataMesgs);
        public ReadOnlyCollection<HsaStepDataMesg> HsaStepDataMesgs => new ReadOnlyCollection<HsaStepDataMesg>(hsaStepDataMesgs);
        public ReadOnlyCollection<HsaSpo2DataMesg> HsaSpo2DataMesgs => new ReadOnlyCollection<HsaSpo2DataMesg>(hsaSpo2DataMesgs);
        public ReadOnlyCollection<HsaStressDataMesg> HsaStressDataMesgs => new ReadOnlyCollection<HsaStressDataMesg>(hsaStressDataMesgs);
        public ReadOnlyCollection<HsaRespirationDataMesg> HsaRespirationDataMesgs => new ReadOnlyCollection<HsaRespirationDataMesg>(hsaRespirationDataMesgs);
        public ReadOnlyCollection<HsaHeartRateDataMesg> HsaHeartRateDataMesgs => new ReadOnlyCollection<HsaHeartRateDataMesg>(hsaHeartRateDataMesgs);
        public ReadOnlyCollection<HsaConfigurationDataMesg> HsaConfigurationDataMesgs => new ReadOnlyCollection<HsaConfigurationDataMesg>(hsaConfigurationDataMesgs);
        public ReadOnlyCollection<HsaWristTemperatureDataMesg> HsaWristTemperatureDataMesgs => new ReadOnlyCollection<HsaWristTemperatureDataMesg>(hsaWristTemperatureDataMesgs);
        public ReadOnlyCollection<MemoGlobMesg> MemoGlobMesgs => new ReadOnlyCollection<MemoGlobMesg>(memoGlobMesgs);
        public ReadOnlyCollection<SleepLevelMesg> SleepLevelMesgs => new ReadOnlyCollection<SleepLevelMesg>(sleepLevelMesgs);
        public ReadOnlyCollection<AntChannelIdMesg> AntChannelIdMesgs => new ReadOnlyCollection<AntChannelIdMesg>(antChannelIdMesgs);
        public ReadOnlyCollection<AntRxMesg> AntRxMesgs => new ReadOnlyCollection<AntRxMesg>(antRxMesgs);
        public ReadOnlyCollection<AntTxMesg> AntTxMesgs => new ReadOnlyCollection<AntTxMesg>(antTxMesgs);
        public ReadOnlyCollection<ExdScreenConfigurationMesg> ExdScreenConfigurationMesgs => new ReadOnlyCollection<ExdScreenConfigurationMesg>(exdScreenConfigurationMesgs);
        public ReadOnlyCollection<ExdDataFieldConfigurationMesg> ExdDataFieldConfigurationMesgs => new ReadOnlyCollection<ExdDataFieldConfigurationMesg>(exdDataFieldConfigurationMesgs);
        public ReadOnlyCollection<ExdDataConceptConfigurationMesg> ExdDataConceptConfigurationMesgs => new ReadOnlyCollection<ExdDataConceptConfigurationMesg>(exdDataConceptConfigurationMesgs);
        public ReadOnlyCollection<DiveSummaryMesg> DiveSummaryMesgs => new ReadOnlyCollection<DiveSummaryMesg>(diveSummaryMesgs);
        public ReadOnlyCollection<AadAccelFeaturesMesg> AadAccelFeaturesMesgs => new ReadOnlyCollection<AadAccelFeaturesMesg>(aadAccelFeaturesMesgs);
        public ReadOnlyCollection<HrvMesg> HrvMesgs => new ReadOnlyCollection<HrvMesg>(hrvMesgs);
        public ReadOnlyCollection<BeatIntervalsMesg> BeatIntervalsMesgs => new ReadOnlyCollection<BeatIntervalsMesg>(beatIntervalsMesgs);
        public ReadOnlyCollection<HrvStatusSummaryMesg> HrvStatusSummaryMesgs => new ReadOnlyCollection<HrvStatusSummaryMesg>(hrvStatusSummaryMesgs);
        public ReadOnlyCollection<HrvValueMesg> HrvValueMesgs => new ReadOnlyCollection<HrvValueMesg>(hrvValueMesgs);
        public ReadOnlyCollection<RawBbiMesg> RawBbiMesgs => new ReadOnlyCollection<RawBbiMesg>(rawBbiMesgs);
        public ReadOnlyCollection<RespirationRateMesg> RespirationRateMesgs => new ReadOnlyCollection<RespirationRateMesg>(respirationRateMesgs);
        public ReadOnlyCollection<ChronoShotSessionMesg> ChronoShotSessionMesgs => new ReadOnlyCollection<ChronoShotSessionMesg>(chronoShotSessionMesgs);
        public ReadOnlyCollection<ChronoShotDataMesg> ChronoShotDataMesgs => new ReadOnlyCollection<ChronoShotDataMesg>(chronoShotDataMesgs);
        public ReadOnlyCollection<TankUpdateMesg> TankUpdateMesgs => new ReadOnlyCollection<TankUpdateMesg>(tankUpdateMesgs);
        public ReadOnlyCollection<TankSummaryMesg> TankSummaryMesgs => new ReadOnlyCollection<TankSummaryMesg>(tankSummaryMesgs);
        public ReadOnlyCollection<SleepAssessmentMesg> SleepAssessmentMesgs => new ReadOnlyCollection<SleepAssessmentMesg>(sleepAssessmentMesgs);
        public ReadOnlyCollection<SkinTempOvernightMesg> SkinTempOvernightMesgs => new ReadOnlyCollection<SkinTempOvernightMesg>(skinTempOvernightMesgs);
        public ReadOnlyCollection<PadMesg> PadMesgs => new ReadOnlyCollection<PadMesg>(padMesgs);
    }
}

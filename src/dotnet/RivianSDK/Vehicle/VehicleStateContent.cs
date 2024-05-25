using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RivianSDK;

public class VehicleStateResponseContent
{
    [JsonProperty("__typename")]
    public string Typename { get; set; }

    [JsonProperty("gnssLocation")]
    public GnssLocation GnssLocation { get; set; }

    [JsonProperty("alarmSoundStatus")]
    public VehicleStateContentProperty AlarmSoundStatus { get; set; }

    [JsonProperty("timeToEndOfCharge")]
    public BatteryLevel TimeToEndOfCharge { get; set; }

    [JsonProperty("doorFrontLeftLocked")]
    public VehicleStateContentProperty DoorFrontLeftLocked { get; set; }

    [JsonProperty("doorFrontLeftClosed")]
    public VehicleStateContentProperty DoorFrontLeftClosed { get; set; }

    [JsonProperty("doorFrontRightLocked")]
    public VehicleStateContentProperty DoorFrontRightLocked { get; set; }

    [JsonProperty("doorFrontRightClosed")]
    public VehicleStateContentProperty DoorFrontRightClosed { get; set; }

    [JsonProperty("doorRearLeftLocked")]
    public VehicleStateContentProperty DoorRearLeftLocked { get; set; }

    [JsonProperty("doorRearLeftClosed")]
    public VehicleStateContentProperty DoorRearLeftClosed { get; set; }

    [JsonProperty("doorRearRightLocked")]
    public VehicleStateContentProperty DoorRearRightLocked { get; set; }

    [JsonProperty("doorRearRightClosed")]
    public VehicleStateContentProperty DoorRearRightClosed { get; set; }

    [JsonProperty("windowFrontLeftClosed")]
    public VehicleStateContentProperty WindowFrontLeftClosed { get; set; }

    [JsonProperty("windowFrontRightClosed")]
    public VehicleStateContentProperty WindowFrontRightClosed { get; set; }

    [JsonProperty("windowFrontLeftCalibrated")]
    public VehicleStateContentProperty WindowFrontLeftCalibrated { get; set; }

    [JsonProperty("windowFrontRightCalibrated")]
    public VehicleStateContentProperty WindowFrontRightCalibrated { get; set; }

    [JsonProperty("windowRearLeftCalibrated")]
    public VehicleStateContentProperty WindowRearLeftCalibrated { get; set; }

    [JsonProperty("windowRearRightCalibrated")]
    public VehicleStateContentProperty WindowRearRightCalibrated { get; set; }

    [JsonProperty("closureFrunkLocked")]
    public VehicleStateContentProperty ClosureFrunkLocked { get; set; }

    [JsonProperty("closureFrunkClosed")]
    public VehicleStateContentProperty ClosureFrunkClosed { get; set; }

    [JsonProperty("closureFrunkNextAction")]
    public VehicleStateContentProperty ClosureFrunkNextAction { get; set; }

    [JsonProperty("gearGuardLocked")]
    public VehicleStateContentProperty GearGuardLocked { get; set; }

    [JsonProperty("closureLiftgateLocked")]
    public VehicleStateContentProperty ClosureLiftgateLocked { get; set; }

    [JsonProperty("closureLiftgateClosed")]
    public VehicleStateContentProperty ClosureLiftgateClosed { get; set; }

    [JsonProperty("closureLiftgateNextAction")]
    public VehicleStateContentProperty ClosureLiftgateNextAction { get; set; }

    [JsonProperty("windowRearLeftClosed")]
    public VehicleStateContentProperty WindowRearLeftClosed { get; set; }

    [JsonProperty("windowRearRightClosed")]
    public VehicleStateContentProperty WindowRearRightClosed { get; set; }

    [JsonProperty("closureSideBinLeftLocked")]
    public VehicleStateContentProperty ClosureSideBinLeftLocked { get; set; }

    [JsonProperty("closureSideBinLeftClosed")]
    public VehicleStateContentProperty ClosureSideBinLeftClosed { get; set; }

    [JsonProperty("closureSideBinRightLocked")]
    public VehicleStateContentProperty ClosureSideBinRightLocked { get; set; }

    [JsonProperty("closureSideBinRightClosed")]
    public VehicleStateContentProperty ClosureSideBinRightClosed { get; set; }

    [JsonProperty("closureSideBinLeftNextAction")]
    public VehicleStateContentProperty ClosureSideBinLeftNextAction { get; set; }

    [JsonProperty("closureSideBinRightNextAction")]
    public VehicleStateContentProperty ClosureSideBinRightNextAction { get; set; }

    [JsonProperty("closureTailgateLocked")]
    public VehicleStateContentProperty ClosureTailgateLocked { get; set; }

    [JsonProperty("closureTailgateClosed")]
    public VehicleStateContentProperty ClosureTailgateClosed { get; set; }

    [JsonProperty("closureTailgateNextAction")]
    public VehicleStateContentProperty ClosureTailgateNextAction { get; set; }

    [JsonProperty("closureTonneauLocked")]
    public VehicleStateContentProperty ClosureTonneauLocked { get; set; }

    [JsonProperty("closureTonneauClosed")]
    public VehicleStateContentProperty ClosureTonneauClosed { get; set; }

    [JsonProperty("wiperFluidState")]
    public VehicleStateContentProperty WiperFluidState { get; set; }

    [JsonProperty("powerState")]
    public VehicleStateContentProperty PowerState { get; set; }

    [JsonProperty("batteryHvThermalEventPropagation")]
    public VehicleStateContentProperty BatteryHvThermalEventPropagation { get; set; }

    [JsonProperty("vehicleMileage")]
    public BatteryLevel VehicleMileage { get; set; }

    [JsonProperty("brakeFluidLow")]
    public object BrakeFluidLow { get; set; }

    [JsonProperty("gearStatus")]
    public VehicleStateContentProperty GearStatus { get; set; }

    [JsonProperty("tirePressureStatusFrontLeft")]
    public VehicleStateContentProperty TirePressureStatusFrontLeft { get; set; }

    [JsonProperty("tirePressureStatusValidFrontLeft")]
    public VehicleStateContentProperty TirePressureStatusValidFrontLeft { get; set; }

    [JsonProperty("tirePressureStatusFrontRight")]
    public VehicleStateContentProperty TirePressureStatusFrontRight { get; set; }

    [JsonProperty("tirePressureStatusValidFrontRight")]
    public VehicleStateContentProperty TirePressureStatusValidFrontRight { get; set; }

    [JsonProperty("tirePressureStatusRearLeft")]
    public VehicleStateContentProperty TirePressureStatusRearLeft { get; set; }

    [JsonProperty("tirePressureStatusValidRearLeft")]
    public VehicleStateContentProperty TirePressureStatusValidRearLeft { get; set; }

    [JsonProperty("tirePressureStatusRearRight")]
    public VehicleStateContentProperty TirePressureStatusRearRight { get; set; }

    [JsonProperty("tirePressureStatusValidRearRight")]
    public VehicleStateContentProperty TirePressureStatusValidRearRight { get; set; }

    [JsonProperty("batteryLevel")]
    public BatteryLevel BatteryLevel { get; set; }

    [JsonProperty("chargerState")]
    public VehicleStateContentProperty ChargerState { get; set; }

    [JsonProperty("batteryLimit")]
    public BatteryLevel BatteryLimit { get; set; }

    [JsonProperty("remoteChargingAvailable")]
    public BatteryLevel RemoteChargingAvailable { get; set; }

    [JsonProperty("batteryHvThermalEvent")]
    public VehicleStateContentProperty BatteryHvThermalEvent { get; set; }

    [JsonProperty("rangeThreshold")]
    public VehicleStateContentProperty RangeThreshold { get; set; }

    [JsonProperty("distanceToEmpty")]
    public BatteryLevel DistanceToEmpty { get; set; }

    [JsonProperty("otaAvailableVersionGitHash")]
    public VehicleStateContentProperty OtaAvailableVersionGitHash { get; set; }

    [JsonProperty("otaAvailableVersionNumber")]
    public BatteryLevel OtaAvailableVersionNumber { get; set; }

    [JsonProperty("otaAvailableVersionWeek")]
    public BatteryLevel OtaAvailableVersionWeek { get; set; }

    [JsonProperty("otaAvailableVersionYear")]
    public BatteryLevel OtaAvailableVersionYear { get; set; }

    [JsonProperty("otaCurrentVersionGitHash")]
    public VehicleStateContentProperty OtaCurrentVersionGitHash { get; set; }

    [JsonProperty("otaCurrentVersionNumber")]
    public BatteryLevel OtaCurrentVersionNumber { get; set; }

    [JsonProperty("otaCurrentVersionWeek")]
    public BatteryLevel OtaCurrentVersionWeek { get; set; }

    [JsonProperty("otaCurrentVersionYear")]
    public BatteryLevel OtaCurrentVersionYear { get; set; }

    [JsonProperty("otaDownloadProgress")]
    public BatteryLevel OtaDownloadProgress { get; set; }

    [JsonProperty("otaInstallDuration")]
    public BatteryLevel OtaInstallDuration { get; set; }

    [JsonProperty("otaInstallProgress")]
    public BatteryLevel OtaInstallProgress { get; set; }

    [JsonProperty("otaInstallReady")]
    public VehicleStateContentProperty OtaInstallReady { get; set; }

    [JsonProperty("otaInstallTime")]
    public BatteryLevel OtaInstallTime { get; set; }

    [JsonProperty("otaInstallType")]
    public VehicleStateContentProperty OtaInstallType { get; set; }

    [JsonProperty("otaStatus")]
    public VehicleStateContentProperty OtaStatus { get; set; }

    [JsonProperty("otaCurrentStatus")]
    public VehicleStateContentProperty OtaCurrentStatus { get; set; }

    [JsonProperty("cabinClimateInteriorTemperature")]
    public BatteryLevel CabinClimateInteriorTemperature { get; set; }

    [JsonProperty("cabinPreconditioningStatus")]
    public VehicleStateContentProperty CabinPreconditioningStatus { get; set; }

    [JsonProperty("cabinPreconditioningType")]
    public VehicleStateContentProperty CabinPreconditioningType { get; set; }

    [JsonProperty("petModeStatus")]
    public VehicleStateContentProperty PetModeStatus { get; set; }

    [JsonProperty("petModeTemperatureStatus")]
    public VehicleStateContentProperty PetModeTemperatureStatus { get; set; }

    [JsonProperty("cabinClimateDriverTemperature")]
    public BatteryLevel CabinClimateDriverTemperature { get; set; }

    [JsonProperty("gearGuardVideoStatus")]
    public VehicleStateContentProperty GearGuardVideoStatus { get; set; }

    [JsonProperty("gearGuardVideoMode")]
    public VehicleStateContentProperty GearGuardVideoMode { get; set; }

    [JsonProperty("gearGuardVideoTermsAccepted")]
    public VehicleStateContentProperty GearGuardVideoTermsAccepted { get; set; }

    [JsonProperty("defrostDefogStatus")]
    public VehicleStateContentProperty DefrostDefogStatus { get; set; }

    [JsonProperty("steeringWheelHeat")]
    public VehicleStateContentProperty SteeringWheelHeat { get; set; }

    [JsonProperty("seatFrontLeftHeat")]
    public VehicleStateContentProperty SeatFrontLeftHeat { get; set; }

    [JsonProperty("seatFrontRightHeat")]
    public VehicleStateContentProperty SeatFrontRightHeat { get; set; }

    [JsonProperty("seatRearLeftHeat")]
    public VehicleStateContentProperty SeatRearLeftHeat { get; set; }

    [JsonProperty("seatRearRightHeat")]
    public VehicleStateContentProperty SeatRearRightHeat { get; set; }

    [JsonProperty("chargerStatus")]
    public VehicleStateContentProperty ChargerStatus { get; set; }

    [JsonProperty("seatFrontLeftVent")]
    public VehicleStateContentProperty SeatFrontLeftVent { get; set; }

    [JsonProperty("seatFrontRightVent")]
    public VehicleStateContentProperty SeatFrontRightVent { get; set; }

    [JsonProperty("chargerDerateStatus")]
    public object ChargerDerateStatus { get; set; }

    [JsonProperty("driveMode")]
    public VehicleStateContentProperty DriveMode { get; set; }

    [JsonProperty("serviceMode")]
    public VehicleStateContentProperty ServiceMode { get; set; }
}

public class VehicleStateContentProperty
{
    [JsonProperty("timeStamp")]
    public DateTimeOffset TimeStamp { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}

public class BatteryLevel
{
    [JsonProperty("timeStamp")]
    public DateTimeOffset TimeStamp { get; set; }

    [JsonProperty("value")]
    public double Value { get; set; }
}

public class GnssLocation
{
    [JsonProperty("latitude")]
    public string Latitude { get; set; }

    [JsonProperty("longitude")]
    public string Longitude { get; set; }

    [JsonProperty("timeStamp")]
    public DateTimeOffset TimeStamp { get; set; }

    [JsonProperty("isAuthorized")]
    public bool IsAuthorized { get; set; }
}

// public partial class VehicleStateContent
// {
//     public static VehicleStateContent FromJson(string json) => JsonConvert.DeserializeObject<VehicleStateContent>(json, QuickType.Converter.Settings);
// }

// public static class Serialize
// {
//     public static string ToJson(this VehicleStateContent self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
// }

// internal static class Converter
// {
//     public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//     {
//         MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//         DateParseHandling = DateParseHandling.None,
//         Converters = {
//             new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//         },
//     };
// }
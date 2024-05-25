using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


namespace RivianSDK;

public class CurrentUserResponseContent
{
    [JsonProperty("__typename")]
    public string Typename { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("settings")]
    public CurrentUserSettings Settings { get; set; }

    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    [JsonProperty("lastName")]
    public string LastName { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("address")]
    public Address Address { get; set; }

    [JsonProperty("vehicles")]
    public VehicleElement[] Vehicles { get; set; }

    [JsonProperty("enrolledPhones")]
    public EnrolledPhone[] EnrolledPhones { get; set; }

    [JsonProperty("pendingInvites")]
    public object[] PendingInvites { get; set; }
}

public partial class Address
{
    [JsonProperty("country")]
    public string Country { get; set; }
}

public partial class EnrolledPhone
{
    [JsonProperty("vas")]
    public EnrolledPhoneVas Vas { get; set; }

    [JsonProperty("enrolled")]
    public Enrolled[] Enrolled { get; set; }
}

public partial class Enrolled
{
    [JsonProperty("deviceType")]
    public string DeviceType { get; set; }

    [JsonProperty("deviceName")]
    public string DeviceName { get; set; }

    [JsonProperty("vehicleId")]
    public string VehicleId { get; set; }

    [JsonProperty("identityId")]
    public string IdentityId { get; set; }

    [JsonProperty("shortName")]
    public string ShortName { get; set; }
}

public partial class EnrolledPhoneVas
{
    [JsonProperty("vasPhoneId")]
    public string VasPhoneId { get; set; }

    [JsonProperty("publicKey")]
    public string PublicKey { get; set; }
}

public partial class CurrentUserSettings
{
    [JsonProperty("distanceUnit")]
    public object DistanceUnit { get; set; }

    [JsonProperty("temperatureUnit")]
    public object TemperatureUnit { get; set; }
}

public partial class VehicleElement
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("owner")]
    public object Owner { get; set; }

    [JsonProperty("roles")]
    public string[] Roles { get; set; }

    [JsonProperty("vin")]
    public string Vin { get; set; }

    [JsonProperty("vas")]
    public VehicleVas Vas { get; set; }

    [JsonProperty("vehicle")]
    public VehicleVehicle Vehicle { get; set; }

    [JsonProperty("settings")]
    public VehicleSettings Settings { get; set; }
}

public partial class VehicleSettings
{
    [JsonProperty("name")]
    public Name Name { get; set; }
}

public partial class Name
{
    [JsonProperty("value")]
    public string Value { get; set; }
}

public partial class VehicleVas
{
    [JsonProperty("vasVehicleId")]
    public string VasVehicleId { get; set; }

    [JsonProperty("vehiclePublicKey")]
    public string VehiclePublicKey { get; set; }
}

public partial class VehicleVehicle
{
    [JsonProperty("deviceSlots")]
    public DeviceSlots DeviceSlots { get; set; }

    [JsonProperty("model")]
    public string Model { get; set; }

    [JsonProperty("mobileConfiguration")]
    public MobileConfiguration MobileConfiguration { get; set; }

    [JsonProperty("maintenanceSchedule")]
    public MaintenanceSchedule MaintenanceSchedule { get; set; }
}

public partial class DeviceSlots
{
    [JsonProperty("phone")]
    public Phone Phone { get; set; }
}

public partial class Phone
{
    [JsonProperty("max")]
    public long Max { get; set; }

    [JsonProperty("free")]
    public long Free { get; set; }
}

public partial class MaintenanceSchedule
{
    [JsonProperty("sections")]
    public Section[] Sections { get; set; }
}

public partial class Section
{
    [JsonProperty("items")]
    public Item[] Items { get; set; }

    [JsonProperty("serviceLifetime")]
    public ServiceLifetime ServiceLifetime { get; set; }
}

public partial class Item
{
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("isDue")]
    public bool? IsDue { get; set; }
}

public partial class ServiceLifetime
{
    [JsonProperty("__typename")]
    public string Typename { get; set; }

    [JsonProperty("km", NullValueHandling = NullValueHandling.Ignore)]
    public long? Km { get; set; }

    [JsonProperty("mi", NullValueHandling = NullValueHandling.Ignore)]
    public long? Mi { get; set; }

    [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
    public long? Year { get; set; }
}

public partial class MobileConfiguration
{
    [JsonProperty("trimOption")]
    public Option TrimOption { get; set; }

    [JsonProperty("exteriorColorOption")]
    public Option ExteriorColorOption { get; set; }

    [JsonProperty("interiorColorOption")]
    public Option InteriorColorOption { get; set; }

    [JsonProperty("driveSystemOption")]
    public Option DriveSystemOption { get; set; }

    [JsonProperty("tonneauOption")]
    public Option TonneauOption { get; set; }

    [JsonProperty("wheelOption")]
    public Option WheelOption { get; set; }

    [JsonProperty("driveSystemTowingDriveModes")]
    public string[] DriveSystemTowingDriveModes { get; set; }

    [JsonProperty("driveSystemDriveModes")]
    public string[] DriveSystemDriveModes { get; set; }

    [JsonProperty("maxVehiclePower")]
    public long MaxVehiclePower { get; set; }
}

public partial class Option
{
    [JsonProperty("optionId")]
    public string OptionId { get; set; }

    [JsonProperty("optionName")]
    public string OptionName { get; set; }
}
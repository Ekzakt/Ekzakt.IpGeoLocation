namespace Ekzakt.IpGeoLocationService.Core.Models;

#nullable disable

public class IpGeoLocation
{
    public string IpAddress { get; set; }

    public Country Country { get; set; } = new();

}

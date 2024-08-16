namespace Ekzakt.IpGeoLocationService.Core.Models;

#nullable disable

public class Country
{
    public string Name { get; set; }

    public List<Currency> Currencies { get; set; } = new();

}

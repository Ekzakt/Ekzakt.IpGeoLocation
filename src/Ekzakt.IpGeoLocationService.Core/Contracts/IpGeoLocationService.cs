using Ekzakt.IpGeoLocationService.Core.Models;

namespace Ekzakt.IpGeoLocationService.Core.Contracts;

public interface IpGeoLocationService
{
    Task<IpGeoLocation> GetLocationAsync(string ipAddress);
}

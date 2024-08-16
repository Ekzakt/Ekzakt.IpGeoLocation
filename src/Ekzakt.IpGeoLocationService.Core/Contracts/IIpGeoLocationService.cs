using Ekzakt.IpGeoLocationService.Core.Models;

namespace Ekzakt.IpGeoLocationService.Core.Contracts;

public interface IIpGeoLocationService
{
    Task<IpGeoLocation> GetLocationAsync(string ipAddress);
}

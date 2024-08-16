using Ekzakt.IpGeoLocationService.Core.Contracts;
using Ekzakt.IpGeoLocationService.Core.Models;

namespace Ekzakt.IpGeoLocationService.IpInfo.Services;

internal class IpGeoLocationService : IIpGeoLocationService
{
    public Task<IpGeoLocation> GetLocationAsync(string ipAddress)
    {
        throw new NotImplementedException();
    }
}

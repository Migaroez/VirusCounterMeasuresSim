using System.Collections.Generic;

namespace Assets.Code.Services
{
    public interface ILocationService
    {
        void AddLocations(IEnumerable<Models.Location> locations);
    }
}
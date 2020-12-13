using System.Collections.Generic;
using Assets.Code.Data;

namespace Assets.Code.Services
{
    public interface ILocationService
    {
        void AddLocations(IEnumerable<Models.Location> locations);
        Vector2Int[] GetLocationPositions();
    }
}
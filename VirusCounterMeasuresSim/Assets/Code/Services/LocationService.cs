using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Services
{
    public class LocationService : ILocationService
    {
        private readonly List<Models.Location> _locations = new List<Models.Location>();

        public void AddLocations(IEnumerable<Models.Location> locations)
        {
            _locations.AddRange(locations);
        }
    }
}

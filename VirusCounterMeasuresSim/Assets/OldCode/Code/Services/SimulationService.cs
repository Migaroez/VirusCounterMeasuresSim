using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Services
{
    /// <summary>
    /// Class that holds general data about the simulation that doesn't belong anywhere else
    /// </summary>
    public class SimulationService : ISimulationService
    {
        public int SimSpeed { get; set; } = 1;
        public bool SimIsPaused { get; set; }
    }
}

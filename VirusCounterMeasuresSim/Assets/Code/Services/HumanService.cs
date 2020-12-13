using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Services
{
    public class HumanService : IHumanService
    {
        private readonly List<Models.Human> _humans = new List<Models.Human>();

        public void AddHumans(IEnumerable<Models.Human> humans)
        {
            _humans.AddRange(humans);
        }
    }
}

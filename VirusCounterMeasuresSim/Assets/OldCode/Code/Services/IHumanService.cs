using System.Collections.Generic;

namespace Assets.Code.Services
{
    public interface IHumanService
    {
        void AddHumans(IEnumerable<Models.Human> humans);
    }
}
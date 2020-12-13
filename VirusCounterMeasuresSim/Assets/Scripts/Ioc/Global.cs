using Assets.Code.Services;
using Core.Ioc;
using UnityEngine;

namespace Scripts.Ioc
{
    public class Global : MonoBehaviour
    {
        // Keep a bindable reference to items in our container so UnityWeld can bind to them
        void Awake()
        {
            DontDestroyOnLoad(this);

            // register services
            DiContainer.Current.Register(new Assets.Code.Services.LocationService() as ILocationService);
            DiContainer.Current.Register(new HumanService() as IHumanService);
            DiContainer.Current.Register(new SimulationService() as ISimulationService);

            // set max framerate
            QualitySettings.vSyncCount = 0;  // VSync must be disabled
            Application.targetFrameRate = 60;
        }

        void Start()
        {
            DiContainer.Current.Start();
        }
    }
}

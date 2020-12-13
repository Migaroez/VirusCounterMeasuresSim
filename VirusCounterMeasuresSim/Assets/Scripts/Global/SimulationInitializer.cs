using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Code.Services;
using UnityEngine;
using Core.Ioc;

public class SimulationInitializer : MonoBehaviour
{
    private LocationHelper _locationHelper;
    private ILocationService _locationService;

    // Start is called before the first frame update
    void Start()
    {
        _locationHelper = DiContainer.Current.Resolve<LocationHelper>();
        _locationService = DiContainer.Current.Resolve<ILocationService>();

        // scan scene for locations, normalize and track them

        var locations = _locationHelper.GetLocations();
        _locationHelper.NormalizeLocations(locations);
        _locationService.AddLocations(locations.Select(l => l.Data));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

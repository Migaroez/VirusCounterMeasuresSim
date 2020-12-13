using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Code.Services;
using Core.Ioc;
using UnityEngine;

public class LocationScanner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var locationService = DiContainer.Current.Resolve<ILocationService>();
        var locations = GameObject.FindObjectsOfType<Location>();
        locationService.AddLocations(locations.Select(l => l.Data));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

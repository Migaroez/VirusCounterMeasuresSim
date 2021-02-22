using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Extensions;
using Assets.Code.Services;

public class Human : MonoBehaviour
{
    private ISimulationService _simulationService;
    
    public Assets.Code.Models.Human Data = new Assets.Code.Models.Human();

    // Start is called before the first frame update
    void Start()
    {
        _simulationService = Core.Ioc.DiContainer.Current.Resolve<ISimulationService>();
    }

    // Update is called once per frame
    void Update()
    {
        // if desired location is different from current location => move
        if (Data.DesiredLocation.IsSameLocation(transform.position) == false)
        {
            //transform.position += (Data.DesiredLocation
        }
    }
}

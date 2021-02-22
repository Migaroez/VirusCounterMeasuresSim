using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Code.Services;
using Core.Ioc;
using UnityEngine;

public class HumanScanner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var humanService = DiContainer.Current.Resolve<IHumanService>();
        var humans = GameObject.FindObjectsOfType<Human>();
        humanService.AddHumans(humans.Select(h => h.Data));
    }

    // Update is called once per frame
    void Update()
    {
    }
}

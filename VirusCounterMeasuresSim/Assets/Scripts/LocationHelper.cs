using System.Collections.Generic;
using Assets.Code.Extensions;
using UnityEngine;

public class LocationHelper
{
    public Location[] GetLocations()
    {
        return Object.FindObjectsOfType<Location>();
    }

    public void NormalizeLocations(IEnumerable<Location> locations)
    {
        foreach (var location in locations)
        {
            location.transform.position = location.transform.position.RoundXZ();
            location.Data.Position = location.transform.position.ToVector2Int();
        }
    }
}

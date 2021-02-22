using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct Infectable : IComponentData
{
    public InfectionType InfectionType;
}

public enum InfectionType
{
    Human = 1
}
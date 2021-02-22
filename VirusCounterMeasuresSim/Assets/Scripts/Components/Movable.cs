﻿
using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct Movable : IComponentData
{
    public float3 Destination;
    public bool WaitingForDestination;
}

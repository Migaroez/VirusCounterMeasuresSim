using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct RandomMoveAssignable : IComponentData
{
    public float3 HomeLocation;
}

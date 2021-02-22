using Unity.Entities;

[GenerateAuthoringComponent]
public struct RectangleSpawn : IComponentData
{
    public Entity Prefab;
    public int TotalAmount;
    public int AmountPerRow;
    public float DistanceRow;
    public float DistanceColumn;
    public bool Center;
}

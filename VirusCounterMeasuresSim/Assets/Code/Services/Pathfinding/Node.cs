using Assets.Code.Data;

public class Node : IHeapItem<Node>
{
    public bool Walkable { get; private set; }
    public Vector2Int GridPos { get; private set; }

    public Node Parent { get; set; }

    public int GCost { get; set; }
    public int HCost { get; set; }
    public int FCost => GCost + HCost;

    public int HeapIndex { get; set; }

    public Node(bool walkable, Vector2Int gridPosition)
    {
        Walkable = walkable;
        GridPos = gridPosition;
    }

    public int CompareTo(Node other)
    {
        int compare = FCost.CompareTo(other.FCost);
        if (compare == 0) { compare = HCost.CompareTo(other.HCost); }
        return -compare;
    }
}
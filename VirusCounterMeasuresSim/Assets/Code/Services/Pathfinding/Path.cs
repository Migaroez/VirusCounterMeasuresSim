using Assets.Code.Data;

public class Path
{
    public readonly Vector2Int[] waypoints;
    public readonly int endIndex;
    public readonly int approachIndex;

    private float _distanceFromEndPoint;

    public Path(Vector2Int[] waypoints, Vector2Int startPos, Vector2Int endPos)
    {
        this.waypoints = waypoints;
        Vector2Int previousPos = startPos;
    }
}

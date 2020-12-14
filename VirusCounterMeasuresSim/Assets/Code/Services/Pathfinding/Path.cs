using Assets.Code.Data;

public class Path
{
    public readonly Vector2Int[] waypoints;
    public readonly Vector2Int startPos;
    public readonly Vector2Int endPos;

    public Path(Vector2Int[] waypoints, Vector2Int startPos, Vector2Int endPos)
    {
        this.waypoints = waypoints;
        this.startPos = startPos;
        this.endPos = endPos;
    }
}

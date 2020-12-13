using System.Numerics;

public class Path
{
    public readonly Vector2[] waypoints;
    public readonly int endIndex;
    public readonly int approachIndex;

    private float _distanceFromEndPoint;

    public Path(Vector2[] waypoints, Vector2 startPos, Vector2 endPos)
    {
        this.waypoints = waypoints;
        Vector2 previousPos = startPos;

        //for (int i = 0; i < waypoints.Length; i++)
        //{
        //    Vector2 current = waypoints[i];
        //    Vector2 dirToCurrent = Vector2.Normalize(current - previousPos);
        //    Vector2 turnBoundaryPoint = (i == endIndex) ? current : current - dirToCurrent * turnDistance;
        //    previousPos = turnBoundaryPoint; // use for smooth turning?
        //}
    }
}

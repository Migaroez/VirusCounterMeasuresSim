using Assets.Code.Data;
using System;
using System.Collections.Generic;

public static class Pathfinder
{
    private static Grid _grid;

    public static void InitializeGrid(int width, int height, IEnumerable<Vector2Int> unwalkableAreas)
    {
        _grid = new Grid(width, height, unwalkableAreas);
    }

    public static Path FindPath(Vector2Int start, Vector2Int end)
    {
        if (_grid == null) throw new NullReferenceException("Grid has not been inititalized.");

        Vector2Int[] waypoints = new Vector2Int[0];
        bool pathFound = false;

        Node startNode = _grid.NodeAtPosition(start);
        Node targetNode = _grid.NodeAtPosition(end);
        startNode.Parent = startNode;

        if (startNode.Walkable && targetNode.Walkable)
        {
            Heap<Node> openSet = new Heap<Node>(_grid.MaxSize);
            HashSet<Node> closedSet = new HashSet<Node>();
            openSet.Add(startNode);

            while (openSet.ItemCount > 0)
            {
                Node currentNode = openSet.RemoveFirst();
                closedSet.Add(currentNode);

                if (currentNode == targetNode) { pathFound = true; break; }

                foreach (Node neighbour in _grid.Neighbours(currentNode))
                {
                    if (!neighbour.Walkable || closedSet.Contains(neighbour)) continue;

                    int moveCostToNeightbour = currentNode.GCost + Distance(currentNode, neighbour);
                    if (moveCostToNeightbour < neighbour.GCost || !openSet.Contains(neighbour))
                    {
                        neighbour.GCost = moveCostToNeightbour;
                        neighbour.HCost = Distance(neighbour, targetNode);
                        neighbour.Parent = currentNode;

                        if (!openSet.Contains(neighbour)) openSet.Add(neighbour);
                        else openSet.UpdateItem(neighbour);
                    }
                }
            }
        }

        if (pathFound) { waypoints = RetracePath(startNode, targetNode); }
        PathRequestManager.SetCurrentRequestFinished(waypoints, pathFound);
        return new Path(waypoints, start, end);
    }

    private static Vector2Int[] RetracePath(Node startNode, Node endNode)
    {
        List<Vector2Int> path = new List<Vector2Int>();
        Node currentNode = endNode;

        while (currentNode != startNode)
        {
            path.Add(currentNode.GridPos);
            currentNode = currentNode.Parent;
        }

        Vector2Int[] waypoints = path.ToArray();
        Array.Reverse(waypoints);
        return waypoints;
    }

    private static int Distance(Node a, Node b)
    {
        int dX = Math.Abs(a.GridPos.X - b.GridPos.X);
        int dY = Math.Abs(a.GridPos.Y - b.GridPos.Y);

        if (dX > dY) return 14 * dY + 10 * (dX - dY);
        return 14 * dX + 10 * (dY - dX);
    }
}

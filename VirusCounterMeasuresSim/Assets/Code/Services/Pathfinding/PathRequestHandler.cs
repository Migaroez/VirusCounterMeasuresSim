using Assets.Code.Data;
using System.Collections.Generic;
using System;

public static class PathRequestManager
{
    private static Queue<PathRequest> pathRequestQueue = new Queue<PathRequest>();
    private static PathRequest currentPathRequest;
    private static bool busy;

    public static void RequestPath(Vector2Int start, Vector2Int end, Action<Vector2Int[], bool> callback)
    {
        PathRequest request = new PathRequest(start, end, callback);
        pathRequestQueue.Enqueue(request);
        TryProcessNext();
    }

    private static void TryProcessNext()
    {
        if (!busy && pathRequestQueue.Count > 0)
        {
            currentPathRequest = pathRequestQueue.Dequeue();
            busy = true;
            Pathfinder.FindPath(currentPathRequest.start, currentPathRequest.end);
        }
    }

    public static void SetCurrentRequestFinished(Vector2Int[] path, bool success)
    {
        currentPathRequest.callback(path, success);
        busy = false;
        TryProcessNext();
    }

    struct PathRequest
    {
        public Vector2Int start;
        public Vector2Int end;
        public Action<Vector2Int[], bool> callback;

        public PathRequest(Vector2Int start, Vector2Int end, Action<Vector2Int[], bool> callback)
        {
            this.start = start;
            this.end = end;
            this.callback = callback;
        }
    }
}
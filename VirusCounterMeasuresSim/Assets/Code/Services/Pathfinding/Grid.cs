using System.Linq;
using System.Collections.Generic;
using Assets.Code.Data;

public class Grid
{
    private readonly Node[,] _grid;
    private readonly int _width, _height;
    private readonly IEnumerable<Vector2Int> _unwalkableAreas;

    public int MaxSize => _width * _height;

    public Grid(int width, int height, IEnumerable<Vector2Int> unwalkableAreas)
    {
        _width = width;
        _height = height;
        _unwalkableAreas = unwalkableAreas;

        _grid = new Node[width, height];

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++)
            {
                _grid[i, j] = new Node(true, new Vector2Int(i, j));
            }
        }
    }

    public List<Node> Neighbours(Node node)
    {
        List<Node> neighbours = new List<Node>();

        for (int x = -1; x <= 1; x++) {
            for (int y = -1; y <= 1; y++)
            {
                if (x == 0 && y == 0) continue;

                int checkX = node.GridPos.X + x;
                int checkY = node.GridPos.Y + y;

                if (checkX >= 0 && checkX < _width && checkY >= 0 && checkY < _height)
                {
                    neighbours.Add(_grid[checkX, checkY]);
                }
            }
        }

        return neighbours;
    }

    public Node NodeAtPosition(Vector2Int position)
    {
        var node = from Node n in _grid
                   where n.GridPos.X == position.X && n.GridPos.Y == position.Y
                   select n;
        return node.Single();
    }
}
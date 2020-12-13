using Assets.Code.Data;

public class Grid
{
    private readonly Vector2Int[,] _grid;
    private readonly int _width, _height;

    public Grid(int width, int height)
    {
        _width = width;
        _height = height;

        _grid = new Vector2Int[width, height];

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++)
            {
                _grid[i, j] = new Vector2Int(i, j);
            }
        }
    }
}
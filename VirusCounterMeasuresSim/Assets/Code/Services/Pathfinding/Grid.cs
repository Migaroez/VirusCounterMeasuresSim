using System.Numerics;

public class Grid
{
    private readonly Vector2[,] _grid;
    private readonly int _width, _height;

    public Grid(int width, int height)
    {
        _width = width;
        _height = height;
        _grid = new Vector2[width, height];
    }
}
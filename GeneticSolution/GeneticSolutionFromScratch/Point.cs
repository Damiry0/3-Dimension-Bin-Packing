namespace GeneticSolutionFromScratch;

public class Point
{
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    public int Volume => X * Y * Z;
}
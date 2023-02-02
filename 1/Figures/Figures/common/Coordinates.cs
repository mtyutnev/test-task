namespace Figures.common;

public struct Coordinates
{
    public readonly double X;
    public readonly double Y;

    public Coordinates(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double CalculateDistances(Coordinates externalCoordinates)
    {
        //Формула подсчета расстояния между 2 точками на оси координат
        return Math.Round(Math.Sqrt(Math.Pow(externalCoordinates.X - X, 2) + Math.Pow(externalCoordinates.Y - Y, 2)), 2);
    }

}
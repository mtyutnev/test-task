using Figures.common;

namespace Figures.figures;

public class Circle : Figure
{
    public double Radius { get; } 
    public override double Area =>Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

    public Circle(Coordinates centerCoordinates, Coordinates coordinatesOnCircle
    ) : base(FigureTypes.Circle, centerCoordinates)
    {
        Radius = centerCoordinates.CalculateDistances(coordinatesOnCircle);

        if (Radius <= 0)
            throw new Exception("Круг не существует");
    }
}
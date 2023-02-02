using Figures.common;
using Figures.figures;

namespace Figures;

public class FactoryFigures : IFactoryFigures
{
    public Figure GetCircle(Coordinates centerCoordinates, Coordinates coordinatesOnCircle)
    {
        return new Circle(centerCoordinates, coordinatesOnCircle);
    }

    public Figure GetRectangle(Coordinates firstCoordinates, Coordinates secondCoordinates,
        Coordinates thirdCoordinates)
    {
        return new Rectangle(firstCoordinates, secondCoordinates, thirdCoordinates);
    }

    public Figure GetTriangle(Coordinates firstCoordinates, Coordinates secondCoordinates,
        Coordinates thirdCoordinates) 
    { 
        return new Triangle(firstCoordinates, secondCoordinates, thirdCoordinates);
    }
}
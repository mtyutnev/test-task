using Figures.common;
using Figures.figures;

namespace Figures;

public interface IFactoryFigures
{
    Figure GetCircle(Coordinates centerCoordinates, Coordinates coordinatesOnCircle);
    Figure GetRectangle(Coordinates firstCoordinates, Coordinates secondCoordinates,
        Coordinates thirdCoordinates);
    Figure GetTriangle(Coordinates firstCoordinates, Coordinates secondCoordinates,
        Coordinates thirdCoordinates);
}
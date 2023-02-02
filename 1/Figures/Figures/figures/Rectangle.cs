using Figures.common;

namespace Figures.figures;

//класс прямоугольника для докозательства возможности добовлять новые фигуры
public class Rectangle : Figure
{
    public double FirstSide { get; } 
    public double SecondSide { get; }
    public override double Area => Math.Round(FirstSide * SecondSide, 2);

    public Rectangle(Coordinates firstCoordinates, Coordinates secondCoordinates,
        Coordinates thirdCoordinates) : base(FigureTypes.Rectangle, firstCoordinates)
    {
        FirstSide = firstCoordinates.CalculateDistances(secondCoordinates);
        SecondSide = secondCoordinates.CalculateDistances(thirdCoordinates);

        if (FirstSide <= 0 || SecondSide <= 0)
            throw new Exception("Прямоугольник не существует");
    }

}
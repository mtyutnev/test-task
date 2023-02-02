using Figures.common;

namespace Figures.figures;

public class Triangle : Figure
{
    public double FirstSide { get; } 
    public double SecondSide { get; }
    public double ThirdSide { get; }
    public override double Area => Math.Round(Math.Sqrt(SemiPerimeter * (SemiPerimeter - FirstSide) 
                                                                      * (SemiPerimeter - SecondSide) 
                                                                      * (SemiPerimeter - ThirdSide)), 2); 
    private double SemiPerimeter => (FirstSide + SecondSide + ThirdSide) / 2;

    public Triangle(Coordinates firstCoordinates, Coordinates secondCoordinates,
        Coordinates thirdCoordinates) : base(FigureTypes.Triangle, firstCoordinates)
    {
        FirstSide = firstCoordinates.CalculateDistances(secondCoordinates);
        SecondSide = secondCoordinates.CalculateDistances(thirdCoordinates);
        ThirdSide = thirdCoordinates.CalculateDistances(firstCoordinates);

        if (FirstSide + SecondSide <= ThirdSide || FirstSide + ThirdSide <= SecondSide ||
            SecondSide + FirstSide <= FirstSide || FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0)
            throw new Exception("Треугольник не существует");
    }

    public bool IsRightTriangle()
    {
        var array = new[] {FirstSide, SecondSide, ThirdSide}.OrderByDescending(x => x).ToArray();
        var max = array[0];
        var min1 = array[1];
        var min2 = array[2];
        
        return Math.Round(Math.Sqrt(Math.Pow(min1, 2) + Math.Pow(min2, 2)), 2) == Math.Round(max, 2);
    }
}
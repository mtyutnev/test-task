using System.ComponentModel;
using Figures.common;

namespace Figures.figures;

public abstract class Figure
{
    protected Figure(FigureTypes type, Coordinates coordinates)
    {
        Type = type;
        Coordinates = coordinates;
    }
    
    public abstract double Area { get; }
    public FigureTypes Type { get; }
    public Coordinates Coordinates { get; }
}
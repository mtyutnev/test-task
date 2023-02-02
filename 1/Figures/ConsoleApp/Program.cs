// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Figures;
using Figures.common;

IFactoryFigures factoryFigures = new FactoryFigures();
var circle = factoryFigures.GetCircle(new Coordinates(0, 0), new Coordinates(10, 0));
var triangle = factoryFigures.GetTriangle(new Coordinates(0, 0), new Coordinates(0, 15), new Coordinates(15, 15));
var rectangle = factoryFigures.GetRectangle(new Coordinates(0, 0), new Coordinates(0, 15), new Coordinates(15, 15));

Console.WriteLine(circle.Type.ToString());
Console.WriteLine(circle.Area.ToString());

Console.WriteLine(triangle.Type.ToString());
Console.WriteLine(triangle.Area.ToString());

Console.WriteLine(rectangle.Type.ToString());
Console.WriteLine(rectangle.Area.ToString());
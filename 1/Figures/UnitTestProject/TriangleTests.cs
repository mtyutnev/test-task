using System;
using Figures.common;
using Figures.figures;
using NUnit.Framework;

namespace UnitTestProject;

public class TriangleTests
{
    [Test]
    public void CreateTriangleWithRightParams()
    {
        try
        {
            var triangle = new Triangle(new Coordinates(0,0),new Coordinates(0,15),
                new Coordinates(10,0));
            Assert.AreEqual(FigureTypes.Triangle, triangle.Type);
        }
        catch (Exception e)
        {
            Assert.Fail("Failed create treangle");
        }
        
    }
    
    [Test]
    public void CreateTriangleWithWrongParams()
    {
        try
        {
            var triangle = new Triangle(new Coordinates(0, 0), new Coordinates(0, 0), 
                new Coordinates(0, 0));
            Assert.Fail("Failed throw exception");
        }
        catch (Exception e)
        {
            Assert.AreEqual("Треугольник не существует", e.Message);
        }
    }
    
    [Test]
    public void CalculateTriangleArea()
    {
        var triangle = new Triangle(new Coordinates(0, 0), new Coordinates(0, 15),
            new Coordinates(15, 15));
        Assert.AreEqual(112.5, triangle.Area);
    }
    
    [Test]
    public void CheckRightTriangle()
    {
        var triangle = new Triangle(new Coordinates(0, 0), new Coordinates(0, 4), 
            new Coordinates(4, 0));
        var result = triangle.IsRightTriangle();
        Assert.AreEqual(true, result);
    }
    
    [Test]
    public void CheckNotRightTriangle()
    {
        var triangle = new Triangle(new Coordinates(0, 0), new Coordinates(0, 15),
            new Coordinates(10, 14));
        var result = triangle.IsRightTriangle();
        Assert.AreEqual(false, result);
    }
}
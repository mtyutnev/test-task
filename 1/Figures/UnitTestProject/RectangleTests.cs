using System;
using Figures.common;
using Figures.figures;
using NUnit.Framework;

namespace UnitTestProject;

public class RectangleTests
{
    [Test]
    public void CreateRectangleWithRightParams()
    {
        try
        {
            var rectangle = new Rectangle(new Coordinates(0,0),new Coordinates(0,15),
                new Coordinates(10,0));
            Assert.AreEqual(FigureTypes.Rectangle, rectangle.Type);
        }
        catch (Exception e)
        {
            Assert.Fail("Failed create rectangle");
        }
        
    }
    
    [Test]
    public void CreateRectangleWithWrongParams()
    {
        try
        {
            var rectangle = new Rectangle(new Coordinates(0, 0), new Coordinates(0, 0), 
                new Coordinates(0, 0));
            Assert.Fail("Failed throw exception");
        }
        catch (Exception e)
        {
            Assert.AreEqual("Прямоугольник не существует", e.Message);
        }
    }
    
    [Test]
    public void CalculateRectangleArea()
    {
        var rectangle = new Rectangle(new Coordinates(0, 0), new Coordinates(0, 15),
            new Coordinates(15, 15));
        Assert.AreEqual(225, rectangle.Area);
    }
}
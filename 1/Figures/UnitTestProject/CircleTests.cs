using System;
using System.ComponentModel.DataAnnotations;
using Figures.common;
using Figures.figures;
using NUnit.Framework;

namespace UnitTestProject;

public class CircleTests
{
    [Test]
    public void CreateCircle()
    {
        var circle = new Circle(new Coordinates(0,0), new Coordinates(15,0));
        Assert.AreEqual(FigureTypes.Circle,circle.Type);
    }
    
    [Test]
    public void CreateNonExistentCircle()
    {
        try
        {
            new Circle(new Coordinates(0,0), new Coordinates(0,0));
            Assert.Fail("Failed throw exception");
        }
        catch (Exception e)
        {
            Assert.IsTrue(e.Message is "Круг не существует");
        }
    }
    
    [Test]
    public void CalculateCircleArea()
    {
        var circle = new Circle(new Coordinates(0,0), new Coordinates(10,0));
        Assert.AreEqual(314,16,circle.Area);
    }
}
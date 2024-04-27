using NUnit.Framework.Legacy;
using ShapeArea.Interfaces;
using ShapeArea.Shapes;

namespace ShapeArea.Tests;

using NUnit.Framework;

[TestFixture]
public class ShapeAreaTests
{
    [Test]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {
        double radius = 5;
        IShape circle = new Circle(radius);
        
        double area = circle.Area();
        
        ClassicAssert.AreEqual(Math.PI * radius * radius, area);
    }

    [Test]
    public void Triangle_CalculateArea_ReturnsCorrectArea()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        IShape triangle = new Triangle(side1, side2, side3);
        
        double area = triangle.Area();
        
        double semiPerimeter = (side1 + side2 + side3) / 2;
        double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        ClassicAssert.AreEqual(expectedArea, area);
    }
}
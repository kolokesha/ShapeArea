using NUnit.Framework.Interfaces;
using NUnit.Framework.Legacy;
using ShapeArea.Shapes;

namespace ShapeArea.Tests;

using NUnit.Framework;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void IsRightTriangle_Returns_True_For_Right_Angle_Triangle()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        
        bool result = triangle.IsRightTriangle();
        
        ClassicAssert.IsTrue(result);

    }

    [Test]
    public void IsRightTriangle_Returns_False_For_Non_Right_Angle_Triangle()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        
        bool result = triangle.IsRightTriangle();
        
        ClassicAssert.IsFalse(result);
    }

    [Test]
    public void IsRightTriangle_Returns_True_For_Isosceles_Right_Angle_Triangle()
    {
        Triangle triangle = new Triangle(1, 1, Math.Sqrt(2));
        
        bool result = triangle.IsRightTriangle();
        
        ClassicAssert.IsTrue(result);
    }

    [Test]
    public void IsRightTriangle_Returns_True_For_Equilateral_Triangle()
    {
        Triangle triangle = new Triangle(3, 3, 3 * Math.Sqrt(2));
        
        bool result = triangle.IsRightTriangle();

        ClassicAssert.IsTrue(result);
    }
}
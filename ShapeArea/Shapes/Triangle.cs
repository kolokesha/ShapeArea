using ShapeArea.Interfaces;

namespace ShapeArea.Shapes;

public class Triangle : IShape
{
    private readonly double _side1, _side2, _side3;

    public Triangle(double side1, double side2, double side3)
    {
        this._side1= side1;
        this._side2 = side2;
        this._side3 = side3;
    }

    public double Area()
    {
        double semiPerimeter = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
    }
    
    public bool IsRightTriangle()
    {
        double[] sides = { _side1, _side2, _side3 };
        Array.Sort(sides);

        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }
}
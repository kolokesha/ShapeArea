using ShapeArea.Interfaces;

namespace ShapeArea.Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        this._radius = radius;
    }

    public double Area()
    {
        return Math.PI * _radius * _radius;
    }
}
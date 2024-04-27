using ShapeArea.Interfaces;
using ShapeArea.Shapes;

namespace ShapeArea.Services;

public class CircleFactory : IShapeFactory
{
    public IShape CreateShape(params double[] parameters)
    {
        if (parameters.Length != 1)
            throw new ArgumentException("Circle requires 1 parameter.");
        return new Circle(parameters[0]);
    }
}
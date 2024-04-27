using ShapeArea.Interfaces;
using ShapeArea.Shapes;

namespace ShapeArea.Services;

public class TriangleFactory : IShapeFactory
{
    public IShape CreateShape(params double[] parameters)
    {
        if (parameters.Length != 3)
            throw new ArgumentException("Triangle requires 3 parameters.");
        return new Triangle(parameters[0], parameters[1], parameters[2]);
    }
}
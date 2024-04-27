﻿namespace ShapeArea.Interfaces;

public interface IShapeFactory
{
    IShape CreateShape(params double[] parameters);
}
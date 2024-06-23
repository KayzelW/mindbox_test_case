namespace Geometry;

public static class ShapeCalculator
{
    public static double GetArea(IShape shape)
    {
        if (shape == null)
            throw new ArgumentException($"shape is null {nameof(shape)}");
        return shape.CalculateArea();
    }
}
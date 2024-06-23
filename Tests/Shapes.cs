using Geometry;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(1e-10));
    }

    [Test]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRightTriangle());
    }

    [Test]
    public void ShapeCalculatorTest()
    {
        IShape circle = new Circle(5);
        IShape triangle = new Triangle(3, 4, 5);

        Assert.That(ShapeCalculator.GetArea(circle), Is.EqualTo(Math.PI * 25).Within(1e-10));
        Assert.That(ShapeCalculator.GetArea(triangle), Is.EqualTo(6).Within(1e-10));
    }
}
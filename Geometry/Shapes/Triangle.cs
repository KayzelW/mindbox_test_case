namespace Geometry;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    // deviation with float/double numbers
    private const double Epsilon = 1e-10;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Sides can't be less than zero");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("This sides can't be interpreted as triangle");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>double Area of a Triangle</returns>
    public double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// checks using the Pythagorean theorem
    /// </summary>
    /// <returns></returns>
    public bool IsRightTriangle()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < Epsilon;
    }
}
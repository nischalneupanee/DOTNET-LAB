using System;

class AreaCalculator
{
    // Area of Circle (1 parameter)
    public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Area of Rectangle (2 parameters)
    public double Area(double length, double width)
    {
        return length * width;
    }

    // Area of Triangle (3 parameters: base, height, flag)
    public double Area(double baseLength, double height, bool isTriangle)
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator calc = new AreaCalculator();

        double circleArea = calc.Area(5.0);
        double rectArea = calc.Area(4.0, 6.0);
        double triArea = calc.Area(6.0, 3.0, true);

        Console.WriteLine("=== Area Calculator (Method Overloading) ===");
        Console.WriteLine($"Area of Circle (r=5.0): {circleArea:F2}");
        Console.WriteLine($"Area of Rectangle (4x6): {rectArea:F2}");
        Console.WriteLine($"Area of Triangle (b=6, h=3): {triArea:F2}");
    }
}

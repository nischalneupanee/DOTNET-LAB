using System;

class Rectangle
{
    private double length;
    private double width;

    // Default constructor
    public Rectangle()
    {
        length = 1.0;
        width = 1.0;
    }

    // Parameterized constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + width);
    }

    // Separate display method
    public void Display()
    {
        Console.WriteLine($"Rectangle [Length: {length}, Width: {width}]");
        Console.WriteLine($"Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Object created with Default Constructor ---");
        Rectangle r1 = new Rectangle();
        r1.Display();

        Console.WriteLine("\n--- Object created with Parameterized Constructor ---");
        Rectangle r2 = new Rectangle(7.5, 4.2);
        r2.Display();
    }
}

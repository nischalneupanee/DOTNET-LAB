using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Triangle.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Method Overriding via Base Class References ===");

        Shape[] shapes = new Shape[]
        {
            new Circle(),
            new Rectangle(),
            new Triangle()
        };

        foreach (Shape s in shapes)
        {
            s.Draw();
        }
    }
}

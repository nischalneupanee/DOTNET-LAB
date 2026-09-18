using System;

class Calculator
{
    // Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("=== Compile-Time Polymorphism (Method Overloading) ===");
        Console.WriteLine($"Add(10, 20): {calc.Add(10, 20)}");
        Console.WriteLine($"Add(5.75, 4.25): {calc.Add(5.75, 4.25)}");
        Console.WriteLine($"Add(10, 20, 30): {calc.Add(10, 20, 30)}");
    }
}

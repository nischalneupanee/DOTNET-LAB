using System;

// Define a delegate for calculating square
delegate double SquareDelegate(double num);

class Program
{
    // Method matching the delegate signature
    static double CalculateSquare(double x)
    {
        return x * x;
    }

    static void Main()
    {
        Console.WriteLine("=== Single-Cast Delegate Demo ===");

        // Instantiate delegate referencing the CalculateSquare method
        SquareDelegate sq = new SquareDelegate(CalculateSquare);

        Console.Write("Enter a number: ");
        double input = double.Parse(Console.ReadLine() ?? "0");

        // Invoke delegate
        double result = sq(input);

        Console.WriteLine($"The square of {input} is: {result}");
    }
}

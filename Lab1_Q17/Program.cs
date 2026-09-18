using System;

// Define delegate signature
delegate void MessageDelegate();

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to C# Programming Lab!");
    }

    static void DisplayDateTime()
    {
        Console.WriteLine($"Current Date and Time: {DateTime.Now}");
    }

    static void Main()
    {
        Console.WriteLine("=== Multicast Delegate Demo ===");

        // Chain methods to create a multicast delegate
        MessageDelegate del = DisplayWelcome;
        del += DisplayDateTime;

        // Invokes both methods sequentially
        del();
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> tokenQueue = new Queue<string>();

        Console.WriteLine("--- Patient Token Queue Arrivals ---");
        tokenQueue.Enqueue("Token #1: John Doe");
        tokenQueue.Enqueue("Token #2: Jane Smith");
        tokenQueue.Enqueue("Token #3: Mike Johnson");
        tokenQueue.Enqueue("Token #4: Sarah Williams");
        Console.WriteLine("Issued tokens to 4 arriving patients.");

        Console.WriteLine("\n--- Current Waiting List ---");
        foreach (var p in tokenQueue)
            Console.WriteLine($"Waiting: {p}");

        Console.WriteLine($"\nNext Patient to be Served: {tokenQueue.Peek()}");

        Console.WriteLine("\n--- Serving Patients ---");
        Console.WriteLine($"Now Serving: {tokenQueue.Dequeue()}");
        Console.WriteLine($"Now Serving: {tokenQueue.Dequeue()}");

        Console.WriteLine($"\nNext Patient to be Served: {tokenQueue.Peek()}");
        Console.WriteLine($"Remaining Patients Waiting: {tokenQueue.Count}");
    }
}

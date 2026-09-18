using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Partial Classes Demonstration (Student) ===");

        // Demonstrating that both parts behave as a single class
        Student s = new Student();
        s.Input();
        s.Display();
    }
}

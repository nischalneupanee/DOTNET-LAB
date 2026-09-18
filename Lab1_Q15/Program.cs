using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Library Management (Partial Classes) ===");

        Book b1 = new Book(101, "The C# Player's Guide", "RB Whitaker");
        Book b2 = new Book(102, "Clean Code", "Robert C. Martin");

        b1.DisplayDetails();
        b2.DisplayDetails();

        Console.WriteLine("\n--- Actions ---");
        b1.IssueBook();
        b1.DisplayDetails();

        b1.ReturnBook();
        b1.DisplayDetails();
    }
}

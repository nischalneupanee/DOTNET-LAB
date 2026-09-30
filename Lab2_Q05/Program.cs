using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> library = new Dictionary<int, string>();

        Console.WriteLine("--- Adding Books ---");
        library[101] = "C# in Depth";
        library[102] = "Clean Architecture";
        library[103] = "The Pragmatic Programmer";
        Console.WriteLine($"Added 3 books. Total Books: {library.Count}");

        Console.WriteLine("\n--- Display All Books ---");
        foreach (var b in library)
            Console.WriteLine($"Book ID: {b.Key} | Title: {b.Value}");

        Console.WriteLine("\n--- Search Book by ID (102) ---");
        if (library.TryGetValue(102, out string title))
            Console.WriteLine($"Found: ID 102 -> '{title}'");

        Console.WriteLine("\n--- Updating Book Title (ID: 101) ---");
        library[101] = "C# 12 in a Nutshell";
        Console.WriteLine($"Updated ID 101: {library[101]}");

        Console.WriteLine("\n--- Removing Book (ID: 103) ---");
        library.Remove(103);
        Console.WriteLine("Book ID 103 removed.");

        Console.WriteLine("\n--- Remaining Available Books ---");
        foreach (var b in library)
            Console.WriteLine($"Book ID: {b.Key} | Title: {b.Value}");
    }
}

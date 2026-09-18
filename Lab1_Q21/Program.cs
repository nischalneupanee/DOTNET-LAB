using System;
using System.Collections.Generic;

class BookCollection
{
    private List<string> bookTitles = new List<string>();

    public void AddBook(string title)
    {
        bookTitles.Add(title);
    }

    // Indexer to access book titles by index position
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < bookTitles.Count)
                return bookTitles[index];
            return "Book not found at this index!";
        }
        set
        {
            if (index >= 0 && index < bookTitles.Count)
                bookTitles[index] = value;
        }
    }

    public int Count => bookTitles.Count;

    public void DisplayAll()
    {
        Console.WriteLine("\n--- Available Books in Collection ---");
        for (int i = 0; i < bookTitles.Count; i++)
        {
            Console.WriteLine($"Index [{i}]: {bookTitles[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Book Collection with Indexer Demo ===");

        BookCollection library = new BookCollection();
        library.AddBook("C# in Depth");
        library.AddBook("Pro C# 10 with .NET 6");
        library.AddBook("Clean Architecture");
        library.AddBook("Design Patterns in C#");

        // Display all stored book titles
        library.DisplayAll();

        // Search for a book using its index
        Console.Write("\nEnter book index to search (0 to {0}): ", library.Count - 1);
        if (int.TryParse(Console.ReadLine(), out int searchIndex))
        {
            Console.WriteLine($"Result: {library[searchIndex]}");
        }
        else
        {
            Console.WriteLine("Invalid index input.");
        }
    }
}

using System;

class StudentCollection
{
    private string[] names = new string[5];

    // Indexer declaration
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= names.Length)
                throw new IndexOutOfRangeException("Index out of bounds (0-4).");
            return names[index];
        }
        set
        {
            if (index < 0 || index >= names.Length)
                throw new IndexOutOfRangeException("Index out of bounds (0-4).");
            names[index] = value;
        }
    }

    public int Count => names.Length;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== StudentCollection with Indexer Demo ===");
        StudentCollection students = new StudentCollection();

        // 1. Adding student names through the indexer
        students[0] = "Aarav";
        students[1] = "Bipana";
        students[2] = "Chetan";
        students[3] = "Deepa";
        students[4] = "Elina";

        // 2. Retrieving student names through the indexer
        Console.WriteLine("\n--- Initial List of Students (Retrieved via Indexer) ---");
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"Student [{i}]: {students[i]}");
        }

        // 3. Updating student names through the indexer
        Console.WriteLine("\n--- Updating Student at index 2 ---");
        students[2] = "Chirag (Updated)";

        Console.WriteLine($"Updated Student [2]: {students[2]}");

        Console.WriteLine("\n--- Final List of Students ---");
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"Student [{i}]: {students[i]}");
        }
    }
}

using System;
using System.Collections.Generic;

// Class implementing indexer to manage student records
public class StudentManager
{
    private List<Student> records = new List<Student>();

    public void Add(Student s)
    {
        records.Add(s);
    }

    // Indexer for accessing and updating student records by index
    public Student this[int index]
    {
        get
        {
            if (index >= 0 && index < records.Count)
                return records[index];
            throw new IndexOutOfRangeException("Invalid student index.");
        }
        set
        {
            if (index >= 0 && index < records.Count)
                records[index] = value;
            else
                throw new IndexOutOfRangeException("Invalid student index.");
        }
    }

    public int Count => records.Count;

    public void ViewAll()
    {
        if (records.Count == 0)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        Console.WriteLine("\n--- Student Records (Accessed via Indexer) ---");
        for (int i = 0; i < records.Count; i++)
        {
            Console.Write($"Index [{i}] -> ");
            this[i].DisplaySummary();
        }
    }
}

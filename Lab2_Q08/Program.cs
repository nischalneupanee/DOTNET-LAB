using System;
using System.Collections.Generic;

// Generic Class to store and display diverse college data
class CollegeEntity<T>
{
    public string Category { get; set; }
    public T Value { get; set; }

    public CollegeEntity(string category, T value)
    {
        Category = category;
        Value = value;
    }

    public void Display() => Console.WriteLine($"[{Category}] {Value}");
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== College Management System ===");

        // 1. Generic Class
        Console.WriteLine("\n--- 1. Generic Class ---");
        var inst = new CollegeEntity<string>("Institution", "National College of Tech");
        var code = new CollegeEntity<int>("College Code", 1045);
        inst.Display();
        code.Display();

        // 2. List<T>: Students (Add, Search, Delete, Display)
        Console.WriteLine("\n--- 2. List<T> (Students) ---");
        List<string> students = new List<string> { "Student: Aarav (CS)", "Student: Bina (IT)" };
        students.Add("Student: Chetan (BCA)"); // Add
        students.Remove("Student: Bina (IT)"); // Delete
        var searchStudent = students.Find(s => s.Contains("Aarav")); // Search
        Console.WriteLine($"Search Result: {searchStudent}");
        Console.WriteLine("Student Records:");
        students.ForEach(s => Console.WriteLine($"  {s}"));

        // 3. Dictionary<TKey, TValue>: Library Books (Add, Update, Search, Delete, Display)
        Console.WriteLine("\n--- 3. Dictionary<int, string> (Library Books) ---");
        Dictionary<int, string> books = new Dictionary<int, string>
        {
            { 201, "C# Programming" },
            { 202, "Data Structures" }
        };
        books.Add(203, "Database Systems"); // Add
        books[201] = "Advanced C# .NET";   // Update
        books.Remove(202);                 // Delete
        Console.WriteLine($"Search Book ID 201: {books[201]}"); // Search
        Console.WriteLine("Available Books:");
        foreach (var b in books) Console.WriteLine($"  [ID: {b.Key}] {b.Value}");

        // 4. Queue<T>: Admission Queue (Enqueue, Dequeue, Peek, Display)
        Console.WriteLine("\n--- 4. Queue<string> (Admission Queue) ---");
        Queue<string> admissions = new Queue<string>();
        admissions.Enqueue("Applicant #1: Ramesh");
        admissions.Enqueue("Applicant #2: Sunita");
        Console.WriteLine($"Next in Queue: {admissions.Peek()}");
        Console.WriteLine($"Admitted & Processed: {admissions.Dequeue()}");
        Console.WriteLine("Remaining Queue:");
        foreach (var a in admissions) Console.WriteLine($"  {a}");

        // 5. Stack<T>: Recent Activities (Push, Pop, Peek, Display)
        Console.WriteLine("\n--- 5. Stack<string> (Recent Activity History) ---");
        Stack<string> activities = new Stack<string>();
        activities.Push("Registered student Chetan");
        activities.Push("Added book ID 203");
        Console.WriteLine($"Top Activity: {activities.Peek()}");
        Console.WriteLine($"Undo Action: {activities.Pop()}");
        Console.WriteLine("Activity History:");
        foreach (var act in activities) Console.WriteLine($"  {act}");
    }
}

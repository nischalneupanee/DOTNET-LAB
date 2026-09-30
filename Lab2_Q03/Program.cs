using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Faculty { get; set; }

    public Student(int id, string name, string faculty)
    {
        Id = id;
        Name = name;
        Faculty = faculty;
    }

    public override string ToString() => $"[ID: {Id}] Name: {Name,-8} | Faculty: {Faculty}";
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(101, "Aarav", "CSIT"),
            new Student(102, "Binita", "BCA"),
            new Student(103, "Chirag", "CSIT"),
            new Student(104, "Deepika", "BIM"),
            new Student(105, "Elina", "BCA")
        };

        Console.WriteLine("--- Initial 5 Students ---");
        students.ForEach(Console.WriteLine);

        Console.WriteLine("\n--- Adding New Student ---");
        students.Add(new Student(106, "Gopal", "BIM"));
        Console.WriteLine("Added: [ID: 106] Name: Gopal    | Faculty: BIM");

        Console.WriteLine("\n--- Searching Student (ID: 103) ---");
        var found = students.Find(s => s.Id == 103);
        Console.WriteLine(found != null ? $"Found: {found}" : "Student not found.");

        Console.WriteLine("\n--- Removing Student (ID: 102) ---");
        students.RemoveAll(s => s.Id == 102);
        Console.WriteLine("Removed student with ID 102.");

        Console.WriteLine("\n--- All Student Records After Operations ---");
        students.ForEach(Console.WriteLine);
    }
}

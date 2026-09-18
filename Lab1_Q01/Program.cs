using System;

class Student
{
    public int StudentId;
    public string StudentName;
    public string Faculty;

    // Default constructor with predefined values
    public Student()
    {
        StudentId = 101;
        StudentName = "Default Student";
        Faculty = "Computer Science";
    }

    // Parameterized constructor accepting values
    public Student(int id, string name, string faculty)
    {
        StudentId = id;
        StudentName = name;
        Faculty = faculty;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {StudentId}, Name: {StudentName}, Faculty: {Faculty}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Default Constructor ---");
        Student s1 = new Student();
        s1.Display();

        Console.WriteLine("\n--- Parameterized Constructor (User Input) ---");
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter Faculty: ");
        string faculty = Console.ReadLine() ?? "";

        Student s2 = new Student(id, name, faculty);
        s2.Display();
    }
}

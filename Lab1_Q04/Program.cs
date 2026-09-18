using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Student : Person
{
    public int RollNumber { get; set; }
    public string Faculty { get; set; }

    public Student(string name, int age, int rollNumber, string faculty)
        : base(name, age)
    {
        RollNumber = rollNumber;
        Faculty = faculty;
    }

    public void DisplayStudent()
    {
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine($"Name: {Name}, Age: {Age}, Roll No: {RollNumber}, Faculty: {Faculty}");
    }
}

class Teacher : Person
{
    public string Subject { get; set; }
    public double Salary { get; set; }

    public Teacher(string name, int age, string subject, double salary)
        : base(name, age)
    {
        Subject = subject;
        Salary = salary;
    }

    public void DisplayTeacher()
    {
        Console.WriteLine("\n--- Teacher Details ---");
        Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}, Salary: ${Salary:F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== College Management System ===");
        Student s = new Student("Aarav Sharma", 20, 101, "BSc. CSIT");
        Teacher t = new Teacher("Dr. Sita Verma", 42, "C# Programming", 75000);

        s.DisplayStudent();
        t.DisplayTeacher();
    }
}

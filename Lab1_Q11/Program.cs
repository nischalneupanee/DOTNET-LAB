using System;

interface IPrintable
{
    void Print();
}

class Student : IPrintable
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }

    public Student(int rollNo, string name, string course)
    {
        RollNo = rollNo;
        Name = name;
        Course = course;
    }

    public void Print()
    {
        Console.WriteLine($"[Student] Roll No: {RollNo}, Name: {Name}, Course: {Course}");
    }
}

class Employee : IPrintable
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(int empId, string name, string department)
    {
        EmpId = empId;
        Name = name;
        Department = department;
    }

    public void Print()
    {
        Console.WriteLine($"[Employee] ID: {EmpId}, Name: {Name}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== IPrintable Interface Implementation ===");

        IPrintable s = new Student(105, "Pooja Thapa", "BIT");
        IPrintable e = new Employee(501, "Suresh Karki", "IT Department");

        s.Print();
        e.Print();
    }
}

using System;

class Person
{
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public double Salary { get; set; }

    public void Input()
    {
        Console.Write("Enter Employee ID: ");
        EmployeeId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Name: ");
        Name = Console.ReadLine() ?? "";
        Console.Write("Enter Address: ");
        Address = Console.ReadLine() ?? "";
        Console.Write("Enter Salary: ");
        Salary = double.Parse(Console.ReadLine() ?? "0");
    }

    public void Display()
    {
        Console.WriteLine("\n--- Employee Information ---");
        Console.WriteLine($"ID: {EmployeeId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Salary: ${Salary:F2}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Input();
        emp.Display();
    }
}

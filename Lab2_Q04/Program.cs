using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public override string ToString() => $"[ID: {Id}] Name: {Name,-8} | Salary: ${Salary:F2}";
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Alice", 50000),
            new Employee(2, "Bob", 60000),
            new Employee(3, "Charlie", 55000)
        };

        Console.WriteLine("--- Adding New Employee ---");
        employees.Add(new Employee(4, "David", 62000));
        Console.WriteLine("Added: [ID: 4] Name: David    | Salary: $62000.00");

        Console.WriteLine("\n--- Display All Employees ---");
        employees.ForEach(Console.WriteLine);

        Console.WriteLine("\n--- Updating Salary for Bob (ID: 2) ---");
        var emp = employees.Find(e => e.Id == 2);
        if (emp != null) emp.Salary = 67500;
        Console.WriteLine($"Updated Record: {emp}");

        Console.WriteLine("\n--- Deleting Employee (ID: 1) ---");
        employees.RemoveAll(e => e.Id == 1);
        Console.WriteLine("Employee with ID 1 deleted.");

        Console.WriteLine($"\nTotal Employees Stored: {employees.Count}");
        Console.WriteLine("--- Final Employee List ---");
        employees.ForEach(Console.WriteLine);
    }
}

using System;

// File 2: Methods of partial class Student
public partial class Student
{
    public void Input()
    {
        Console.Write("Enter Student ID: ");
        StudentID = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter Student Name: ");
        StudentName = Console.ReadLine() ?? "";
    }

    public void Display()
    {
        Console.WriteLine($"\n[Student Info] ID: {StudentID}, Name: {StudentName}");
    }
}

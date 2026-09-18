using System;

// File 1: Data members of partial class Student
public partial class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double[] Marks { get; set; } = Array.Empty<double>();

    public Student() { }

    public Student(int id, string name, double[] marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
}

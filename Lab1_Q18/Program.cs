using System;

// Delegates for calculation methods
delegate double TotalDelegate(double[] marks);
delegate double PercentageDelegate(double total, int count);
delegate string GradeDelegate(double percentage);

class StudentResult
{
    public static double CalculateTotal(double[] marks)
    {
        double sum = 0;
        foreach (double m in marks) sum += m;
        return sum;
    }

    public static double CalculatePercentage(double total, int count)
    {
        return total / count;
    }

    public static string CalculateGrade(double percentage)
    {
        if (percentage >= 80) return "Distinction (A+)";
        if (percentage >= 70) return "First Division (A)";
        if (percentage >= 60) return "Second Division (B)";
        if (percentage >= 50) return "Third Division (C)";
        return "Fail (F)";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Student Result Processing System ===");

        // Delegate instances
        TotalDelegate totalOp = StudentResult.CalculateTotal;
        PercentageDelegate pctOp = StudentResult.CalculatePercentage;
        GradeDelegate gradeOp = StudentResult.CalculateGrade;

        string studentName = "Prashant Thapa";
        double[] marks = { 85, 78, 92, 74, 88 }; // 5 subjects

        // Invoke methods via delegates
        double total = totalOp(marks);
        double percentage = pctOp(total, marks.Length);
        string grade = gradeOp(percentage);

        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Total Marks : {total} / {marks.Length * 100}");
        Console.WriteLine($"Percentage  : {percentage:F2}%");
        Console.WriteLine($"Grade       : {grade}");
    }
}

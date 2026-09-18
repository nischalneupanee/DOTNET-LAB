using System;

// Delegates for calculation
public delegate double CalcTotalDelegate(double[] marks);
public delegate double CalcPctDelegate(double total, int subjectCount);
public delegate string CalcGradeDelegate(double percentage);

// File 2: Partial class Student methods and processing
public partial class Student
{
    // Delegate calculation methods
    public static double GetTotal(double[] marks)
    {
        double sum = 0;
        foreach (double m in marks) sum += m;
        return sum;
    }

    public static double GetPercentage(double total, int count)
    {
        return count == 0 ? 0 : total / count;
    }

    public static string GetGrade(double pct)
    {
        if (pct >= 80) return "A+ (Distinction)";
        if (pct >= 70) return "A (First Division)";
        if (pct >= 60) return "B (Second Division)";
        if (pct >= 50) return "C (Pass)";
        return "F (Fail)";
    }

    public void ProcessAndDisplayResult(CalcTotalDelegate calcTotal, CalcPctDelegate calcPct, CalcGradeDelegate calcGrade)
    {
        double total = calcTotal(Marks);
        double pct = calcPct(total, Marks.Length);
        string grade = calcGrade(pct);

        Console.WriteLine($"\n--- Student Result: {Name} (ID: {Id}) ---");
        Console.WriteLine($"Marks: [{string.Join(", ", Marks)}]");
        Console.WriteLine($"Total Marks : {total} / {Marks.Length * 100}");
        Console.WriteLine($"Percentage  : {pct:F2}%");
        Console.WriteLine($"Grade       : {grade}");
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"ID: {Id} | Name: {Name} | Subjects: {Marks.Length}");
    }
}

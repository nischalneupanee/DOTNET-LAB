using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine(" Student Management System (Partial, Del, Index) ");
        Console.WriteLine("=================================================");

        StudentManager manager = new StudentManager();

        // Delegate instances for calculating results
        CalcTotalDelegate totalCalc = Student.GetTotal;
        CalcPctDelegate pctCalc = Student.GetPercentage;
        CalcGradeDelegate gradeCalc = Student.GetGrade;

        // Prepopulate sample data
        manager.Add(new Student(101, "Aarav Sharma", new double[] { 85, 90, 78 }));
        manager.Add(new Student(102, "Bina Basnet", new double[] { 65, 72, 68 }));

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. View All Students (Indexer)");
            Console.WriteLine("2. Add New Student");
            Console.WriteLine("3. Update Student (Indexer)");
            Console.WriteLine("4. Process & Display Results (Delegates)");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice (1-5): ");

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    manager.ViewAll();
                    break;

                case "2":
                    Console.Write("Enter Student ID: ");
                    int id = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine() ?? "";
                    Console.Write("Enter 3 Subject Marks separated by space: ");
                    string[] parts = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    double[] marks = Array.ConvertAll(parts, double.Parse);
                    manager.Add(new Student(id, name, marks));
                    Console.WriteLine("Student added successfully!");
                    break;

                case "3":
                    manager.ViewAll();
                    Console.Write("Enter index to update: ");
                    int updateIdx = int.Parse(Console.ReadLine() ?? "-1");
                    if (updateIdx >= 0 && updateIdx < manager.Count)
                    {
                        Console.Write("Enter Updated Name: ");
                        string updatedName = Console.ReadLine() ?? "";
                        // Updating student via indexer
                        manager[updateIdx].Name = updatedName;
                        Console.WriteLine("Student updated successfully using Indexer!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "4":
                    manager.ViewAll();
                    Console.Write("Enter index to process result: ");
                    int procIdx = int.Parse(Console.ReadLine() ?? "-1");
                    if (procIdx >= 0 && procIdx < manager.Count)
                    {
                        // Process using delegates
                        manager[procIdx].ProcessAndDisplayResult(totalCalc, pctCalc, gradeCalc);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}

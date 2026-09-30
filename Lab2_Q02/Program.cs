using System;

class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.WriteLine("--- Swapping Integers ---");
        int num1 = 10, num2 = 20;
        Console.WriteLine($"Before: num1 = {num1}, num2 = {num2}");
        Swap(ref num1, ref num2);
        Console.WriteLine($"After : num1 = {num1}, num2 = {num2}");

        Console.WriteLine("\n--- Swapping Strings ---");
        string str1 = "Visual", str2 = "Studio";
        Console.WriteLine($"Before: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"After : str1 = {str1}, str2 = {str2}");

        Console.WriteLine("\n--- Swapping Doubles ---");
        double d1 = 12.34, d2 = 56.78;
        Console.WriteLine($"Before: d1 = {d1}, d2 = {d2}");
        Swap(ref d1, ref d2);
        Console.WriteLine($"After : d1 = {d1}, d2 = {d2}");
    }
}

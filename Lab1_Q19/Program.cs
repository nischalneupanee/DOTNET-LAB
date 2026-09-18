using System;

// Delegate for addition of two numbers
delegate int AddDelegate(int a, int b);

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Anonymous Methods and Lambda Expressions with Delegates ===");

        int num1 = 25;
        int num2 = 17;

        // 1. Implementation using an Anonymous Method (delegate keyword)
        AddDelegate addAnon = delegate(int a, int b)
        {
            return a + b;
        };
        int resultAnon = addAnon(num1, num2);
        Console.WriteLine($"Anonymous Method : {num1} + {num2} = {resultAnon}");

        // 2. Implementation using a Lambda Expression (=> operator)
        AddDelegate addLambda = (a, b) => a + b;
        int resultLambda = addLambda(num1, num2);
        Console.WriteLine($"Lambda Expression: {num1} + {num2} = {resultLambda}");
    }
}

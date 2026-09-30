using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> undoStack = new Stack<string>();

        Console.WriteLine("--- Performing Text Editor Actions ---");
        undoStack.Push("Action 1: Type 'Hello World'");
        undoStack.Push("Action 2: Format bold");
        undoStack.Push("Action 3: Insert table");
        undoStack.Push("Action 4: Delete sentence");
        Console.WriteLine("Pushed 4 actions onto stack.");

        Console.WriteLine("\n--- Current Actions in Stack ---");
        foreach (var act in undoStack)
            Console.WriteLine($" - {act}");

        Console.WriteLine($"\nCurrent Top Action: {undoStack.Peek()}");

        Console.WriteLine("\n--- Undoing Most Recent Action ---");
        Console.WriteLine($"Undone: {undoStack.Pop()}");

        Console.WriteLine($"\nCurrent Top Action After Undo: {undoStack.Peek()}");

        Console.WriteLine("\n--- Remaining Actions in Stack ---");
        foreach (var act in undoStack)
            Console.WriteLine($" - {act}");
    }
}

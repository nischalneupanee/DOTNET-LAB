using System;

class DataStorage<T>
{
    private T data;

    public DataStorage(T value) => data = value;

    public void Display() => Console.WriteLine($"Stored Value ({typeof(T).Name}): {data}");
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Generic Class DataStorage<T> ---");
        var intStore = new DataStorage<int>(100);
        var strStore = new DataStorage<string>("Antigravity C# Lab");
        var dblStore = new DataStorage<double>(98.75);

        intStore.Display();
        strStore.Display();
        dblStore.Display();
    }
}

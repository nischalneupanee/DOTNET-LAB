using System;

abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }

    public Vehicle(string vehicleNumber, string brand)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
    }

    public abstract void Start();
}

class Car : Vehicle
{
    public Car(string vehicleNumber, string brand) : base(vehicleNumber, brand) { }

    public override void Start()
    {
        Console.WriteLine($"Car [{Brand}, No: {VehicleNumber}] starts with key ignition / push button: Vroom Vroom!");
    }
}

class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand) : base(vehicleNumber, brand) { }

    public override void Start()
    {
        Console.WriteLine($"Bike [{Brand}, No: {VehicleNumber}] starts with kick / self start: Rev Rev!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Abstract Class Vehicle Demo ===");

        Car car = new Car("BA-2-KHA-1024", "Toyota");
        Bike bike = new Bike("BA-9-PA-5541", "Yamaha");

        car.Start();
        bike.Start();
    }
}

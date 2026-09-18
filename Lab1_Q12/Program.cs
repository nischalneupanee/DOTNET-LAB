using System;

interface ICamera
{
    void TakePhoto();
}

interface IMusicPlayer
{
    void PlayMusic();
}

class SmartPhone : ICamera, IMusicPlayer
{
    public string Model { get; set; }

    public SmartPhone(string model)
    {
        Model = model;
    }

    public void TakePhoto()
    {
        Console.WriteLine($"{Model}: Photo captured with 50MP Camera! [Click!]");
    }

    public void PlayMusic()
    {
        Console.WriteLine($"{Model}: Playing high-fidelity music track... [♪♫]");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Multiple Interface Implementation Demo ===");

        SmartPhone phone = new SmartPhone("Galaxy Ultra");

        phone.TakePhoto();
        phone.PlayMusic();
    }
}

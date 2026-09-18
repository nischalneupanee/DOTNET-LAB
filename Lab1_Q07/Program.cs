using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a generic sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Bark! Bark!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says: Meow! Meow!");
    }
}

class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cow says: Moo! Moo!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Runtime Polymorphism with Base Class References ===");

        // Using base class reference to demonstrate runtime polymorphism
        Animal refAnimal;

        refAnimal = new Dog();
        refAnimal.MakeSound();

        refAnimal = new Cat();
        refAnimal.MakeSound();

        refAnimal = new Cow();
        refAnimal.MakeSound();
    }
}

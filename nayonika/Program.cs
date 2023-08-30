using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The bird chirps.");
    }
}

class Program
{
   
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.MakeSound();  // Output: The dog barks.

            Animal cat = new Cat();
            cat.MakeSound();  // Output: The cat meows.

            Animal bird = new Bird();
            bird.MakeSound(); // Output: The bird chirps.
        }
    }
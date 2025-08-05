using System;

namespace AssignmentApp
{
    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Demo class to run the code
    public class InheritanceDemo
    {
        public static void Run()
        {
            Animal a = new Animal();
            Animal d = new Dog();
            Animal c = new Cat();

            a.MakeSound();  // Output: Some generic sound
            d.MakeSound();  // Output: Bark
            c.MakeSound();  // Output: Meow
        }

        // Entry point of the program
        public static void Main(string[] args)
        {
            Run();
        }
    }
}
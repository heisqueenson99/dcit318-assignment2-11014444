using System;

namespace AssignmentApp
{
    // Interface definition
    interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Demo class
    class InterfaceDemo
    {
        public static void Run()
        {
            IMovable car = new Car();
            IMovable bike = new Bicycle();

            car.Move();
            bike.Move();
        }

        // Entry point
        public static void Main(string[] args)
        {
            Run();
        }
    }
}
using System;

namespace AssignmentApp
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle class
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Demo class
    class AbstractDemo
    {
        public static void Run()
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine("Circle area: " + circle.GetArea());
            Console.WriteLine("Rectangle area: " + rectangle.GetArea());
        }

        // Entry point
        public static void Main(string[] args)
        {
            Run();
        }
    }
}
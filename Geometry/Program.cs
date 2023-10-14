// Alexander Doja
// NET23

namespace Geometry
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Circle cirkel1 = new Circle(5);
            Circle cirkel2 = new Circle(6);

            Sphere sfär1 = new Sphere(5);

            Triangle triangel1 = new Triangle(4.34, 3.79);

            // Convert to string for formatting with 4 decimals
            Console.WriteLine($"Cirkel 1 har arean: {cirkel1.GetArea().ToString($"F{4}")}");
            Console.WriteLine($"Cirkel 1 har omkretsen: {cirkel1.GetCircumference().ToString($"F{4}")}\n");

            Console.WriteLine($"Cirkel 2 har arean: {cirkel2.GetArea().ToString($"F{4}")}");
            Console.WriteLine($"Cirkel 2 har omkretsen: {cirkel2.GetCircumference().ToString($"F{4}")}\n");

            Console.WriteLine($"Sfär 1 har volymen: {sfär1.GetVolume().ToString($"F{4}")}\n");

            Console.WriteLine($"Triangel 1 har arean: {triangel1.GetArea().ToString($"F{4}")}");
        }
    }

    public class Circle
    {
        protected double _radius; // Only allow access in this class and derived classes.

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return _radius * _radius * Math.PI; // Calculate area with Math.PI
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * _radius;
        }
    }

    // Inherits circle
    public class Sphere : Circle
    {
        // Use the base class Constructor
        public Sphere(double radius) : base(radius)
        {

        }

        public double GetVolume()
        {
            return (4 * Math.PI * Math.Pow(_radius, 3)) / 3;
        }
    }

    public class Triangle
    {
        protected double _width, _height;
        public Triangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            return (_width * _height) / 2;
        }
    }
}
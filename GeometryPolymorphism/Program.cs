namespace GeometryPolymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Geometri shape; // Create an object reference from the Geometri class

            shape = new Cirkel(); // Instantiate shape to Cirkel
            Console.WriteLine($"Area Cirkel: {shape.Area()}");

            shape = new Rektangel(); // Overwrite shape to be Rektangel
            Console.WriteLine($"Area Rektangel: {shape.Area()}");

            shape = new Fyrkant();
            Console.WriteLine($"Area Fyrkant: {shape.Area()}");

            shape = new Parallellogram();
            Console.WriteLine($"Area Parallellogram: {shape.Area()}");

            shape = new Ellips();
            Console.WriteLine($"Area Ellips: {shape.Area()}");
        }
    }

    abstract class Geometri
    {
        public abstract double Area(); // Every child class needs to implement Area()
    }

    class Cirkel:Geometri
    {
        public double _radie {get; set;}

        public Cirkel()
        {
            _radie = 5; // Every shape gets a default value for required properties.
        }

        public override double Area()
        {
            return _radie * _radie * Math.PI;
        }
    }

    class Rektangel:Geometri
    {
        public double _bas {get; set;}
        public double _höjd {get; set;}


        public Rektangel()
        {
            _bas = 5;
            _höjd = 10;
        }

        public override double Area()
        {
            return _bas * _höjd;
        }
    }

    class Fyrkant:Geometri
    {
        public double _sida {get; set;}

        public Fyrkant()
        {
            _sida = 5;
        }

        public override double Area()
        {
            return _sida * _sida;
        }
    }

    class Parallellogram:Geometri
    {
        public double _bas {get; set;}
        public double _höjd {get; set;}


        public Parallellogram()
        {
            _bas = 5;
            _höjd = 10;
        }

        public override double Area()
        {
            return _bas * _höjd;
        }
    }

    class Ellips:Geometri
    {
        public double _lillaxel {get; set;}
        public double _storaxel {get; set;}

        public Ellips()
        {
            _lillaxel = 3;
            _storaxel = 5;
        }

        public override double Area()
        {
            return _lillaxel * _storaxel * Math.PI / 4;
        }
    }
}
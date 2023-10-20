namespace ZooAnimals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Rat rat1 = new Rat();
            BlackRat rat2 = new BlackRat();
            Mouse stuart = new Mouse("stuart", 5, 14, 0.2, 4, false, true);
            Owl owl1 = new Owl();
            Salmon salmon1 = new Salmon();

            rat1.MakeSound();
            rat2.MakeSound();
            stuart.MakeSound();
            owl1.MakeSound();
            salmon1.MakeSound();

            Console.WriteLine();

            rat1.PrintAnimal();
            rat2.PrintAnimal();
            stuart.PrintAnimal();
            owl1.PrintAnimal();
            salmon1.PrintAnimal();

            Console.WriteLine();

            rat2.Infect();

            Console.WriteLine();

            stuart.EatCheese();
            rat2.RideShip();
            
            Console.WriteLine();

            owl1.RotateHead(135);
            owl1.RotateHead(5);

            Console.WriteLine();

            salmon1.Swim();

            Console.WriteLine();

            salmon1.Sleep();
            salmon1.Eat();
        }
    }

    public class Animal
    {
        protected string _givenName;
        protected int _age;
        protected double _maxSpeed, _weight, _length;

        public Animal(string givenName, int age, double maxSpeed, double weight, double length)
        {
            _givenName = givenName;
            _age = age;
            _maxSpeed = maxSpeed;
            _weight = weight;
            _length = length;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public void Eat()
        {
            Console.WriteLine($"{_givenName} is eating!");
        }

        public void Sleep()
        {
            Console.WriteLine($"{_givenName} is sleeping!");
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"name: {_givenName}, age: {_age} years, maxSpeed: {_maxSpeed} km/h, weight: {_weight} kg, length: {_length} cm");
        }
    }

    public class Rat:Animal
    {
        bool _isPlagueRat;
        public Rat(string givenName = "rat", int age = 0, double maxSpeed = 14, double weight = 0.3, double length = 20, bool isPlagueRat = false):base(givenName, age, maxSpeed, weight, length)
        {
            _isPlagueRat = isPlagueRat;
        }

        public void Infect()
        {
            if (_isPlagueRat)
            {
                Console.WriteLine($"The rat {_givenName} is infecting with a plague!");
            }
            else
            {
                Console.WriteLine($"The rat {_givenName} is not a plague rat, can't infect");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("The rat squeaks");
        }
    }

    public class Mouse:Rat
    {
        bool _isFriendly;

        public Mouse(string givenName = "mouse", int age = 0, double maxSpeed = 14, double weight = 0.3, double length = 20, bool isPlagueRat = false, bool isFriendly = true):base(givenName, age, maxSpeed, weight, length, isPlagueRat)
        {
            _isFriendly = isFriendly;
        }

        public void EatCheese()
        {
            string alignment = _isFriendly ? "Friendly" : "Evil";

            Console.WriteLine($"The {alignment} Mouse is eating cheese");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The mouse squeaks");
        }
    }

    public class BlackRat:Rat
    {
        protected string _color;

        public BlackRat(string givenName = "black rat", int age = 0, double maxSpeed = 14, double weight = 0.3, double length = 20, bool isPlagueRat = false):base(givenName, age, maxSpeed, weight, length, isPlagueRat)
        {
            _color = "black";
        }

        public void RideShip()
        {
            Console.WriteLine($"The {_color} rat is riding a ship");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {_color} rat squeaks");
        }
    }

    public class Owl:Animal
    {
        protected short _currentHeadRotation;
        public Owl(string givenName = "owl", int age = 0, double maxSpeed = 50, double weight = 1.0, double length = 30.0):base(givenName, age, maxSpeed, weight, length)
        {
            _currentHeadRotation = 0;
        }

        public void RotateHead(short degrees)
        {
            if ((_currentHeadRotation + degrees > 135) || (_currentHeadRotation + degrees < -135))
            {
                Console.WriteLine($"Can't rotate head {degrees + _currentHeadRotation} degrees");
            }
            else
            {
                _currentHeadRotation += degrees;
                Console.WriteLine($"Current head rotation is {_currentHeadRotation} degrees");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("The owl hoots");
        }
    }

    public class Salmon:Animal
    {
        protected double _depth;
        public Salmon(string givenName = "salmon", int age = 0, double maxSpeed = 19.3, double weight = 5, double length = 60, double depth = 50):base(givenName, age, maxSpeed, weight, length)
        {
            _depth = depth; 
        }

        public void Swim()
        {
            Console.WriteLine($"The salmon is swimming at {_depth} cm depth");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The salmon says Blub-blub blub");
        }
    }
}
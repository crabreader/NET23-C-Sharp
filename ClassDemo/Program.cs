namespace ClassDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer jonas = new Customer(1, "Jonas", "Sjöberg");

            Customer peter = new Customer(10);

            Customer adam = new Customer();

            Customer kevin = new Customer("Kevin", "Johansson");

            jonas.PrintCustomerInfo();
            peter.PrintCustomerInfo();
            adam.PrintCustomerInfo();
            kevin.PrintCustomerInfo();
            
        }
    }

    public class Customer
    {
        public int _id;
        public string _firstName;
        public string _lastName;

        public Customer()
        {
            _id = 1;
            _firstName = "Peter";
            _lastName = "Peter";
        }

        public Customer(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public Customer(string firstName, string lastName)
        {
            _id = 1;
            _firstName = firstName;
            _lastName = lastName;
        }

        public Customer(int id)
        {
            _id = id;
            _firstName = "Unknown";
            _lastName = "Unknown";
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine("Name: {0} {1}", _firstName, _lastName);
        }
    }
}
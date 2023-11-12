using System.Diagnostics;

namespace employeeStack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("###############################");
            Console.WriteLine("Del 1 - Stack");
            Console.WriteLine("###############################");
            
            Employee e1 = new Employee(0, "Bill Jobs", "Male", 125000);
            Employee e2 = new Employee(1, "Steve Gates", "Male", 150000);
            Employee e3 = new Employee(2, "Jimmy Chiker", "Male", 75000);
            Employee e4 = new Employee(3, "Ada Lovelace", "Female", 110000);
            Employee e5 = new Employee(4, "Sarah Connor", "Female", 79000);

            Stack<Employee> employeeStack = new Stack<Employee>();

            employeeStack.Push(e1);
            employeeStack.Push(e2);
            employeeStack.Push(e3);
            employeeStack.Push(e4);
            employeeStack.Push(e5);

            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"{employee._id}, {employee._name}, {employee._gender}, {employee._salary}");
                Console.WriteLine($"Items left in stack = {employeeStack.Count}");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Retrieve using Pop method");

            Employee top;

            while(employeeStack.Count > 0)
            {
                top = employeeStack.Pop();

                Console.WriteLine($"{top._id}, {top._name}, {top._gender}, {top._salary}");
                Console.WriteLine($"Items left in stack = {employeeStack.Count}");
            }

            employeeStack.Push(e1);
            employeeStack.Push(e2);
            employeeStack.Push(e3);
            employeeStack.Push(e4);
            employeeStack.Push(e5);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Retrieve using Peek method");

            top = employeeStack.Peek();
            Console.WriteLine($"{top._id}, {top._name}, {top._gender}, {top._salary}");
            Console.WriteLine($"Items left in stack = {employeeStack.Count}");

            top = employeeStack.Peek();
            Console.WriteLine($"{top._id}, {top._name}, {top._gender}, {top._salary}");
            Console.WriteLine($"Items left in stack = {employeeStack.Count}");

            Console.WriteLine("-------------------------------");   
            Console.WriteLine($"Contains e3: {employeeStack.Contains(e3)}");

            Console.WriteLine("###############################");
            Console.WriteLine("Del 2 - List");
            Console.WriteLine("###############################");

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(e1);
            employeeList.Add(e2);
            employeeList.Add(e3);
            employeeList.Add(e4);
            employeeList.Add(e5);

            if (employeeList.Contains(e2))
            {
                Console.WriteLine("e2 object exists in the list");
            } 
            else
            {
                Console.WriteLine("e2 object does not exist in the list");
            }

            Console.WriteLine("-------------------------------");

            Employee? needle = employeeList.Find(x => x._gender == "Female");

            if (needle != null)
            {
                Console.WriteLine($"{needle._id}, {needle._name}, {needle._gender}, {needle._salary}");
            }
            else
            {
                Console.WriteLine("Employee was not found");
            }
            

            Console.WriteLine("-------------------------------");

            List<Employee> findAllList = employeeList.FindAll(x => x._gender == "Female");

            foreach (var employee in findAllList)
            {
                Console.WriteLine($"{employee._id}, {employee._name}, {employee._gender}, {employee._salary}");
            }

        }
    }

    public class Employee
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public decimal _salary { get; set; }

        public Employee(int id, string name, string gender, decimal salary)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _salary = salary;
        }
    }
}
namespace ListDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 11, 10, 20, 30, 40, 50, 10};

            myList.Add(150);

            myList.Remove(10);

            myList.RemoveAt(0);

            myList.RemoveRange(4, 2);

            //myList.Clear();

            int result = myList.Count;
            Console.WriteLine("Count result: " +result);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Student S1 = new Student();
            S1.Id = 1;
            S1.Name = "Aldor";
            S1.Class = "NET23";

            Student S2 = new Student();
            S2.Id = 2;
            S2.Name = "Reidar";
            S2.Class = "NET23";

            List<Student> students = new List<Student>();

            students.Add(S1);
            students.Add(S2);

            foreach (var student in students)
            {
                Console.WriteLine($"id: {student.Id}\nname: {student.Name}\nclass: {student.Class}");
            }

        }
    }

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Class { get; set; }


    }
}
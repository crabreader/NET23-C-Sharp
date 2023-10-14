namespace EncapsulationDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student myStudent = new Student();
            // myStudent._id = -10;
            // myStudent._name = null;
            // myStudent._grade = -50;

            // Console.WriteLine("ID = {0} \nName: {1}\nGrade = {2}", myStudent._id, myStudent._name, myStudent._grade);

            myStudent.Id = -10;

            Console.WriteLine(myStudent.Id);
        }
    }
}
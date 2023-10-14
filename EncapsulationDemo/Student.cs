namespace EncapsulationDemo;
internal class Student
{
    private int _id;
    private string _name;
    private int _grade;

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value >= 0)
            {
                _id = value;   
            }
            else
            {
                _id = 0;
            }
        }
    }

    public string GetName()
    {
        return _name;
    }
}

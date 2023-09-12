string userRole = "mod";

string loginAs = (userRole == "admin") ? "Du är Admin" : "Du är Kund";

Console.WriteLine(loginAs);

Console.WriteLine("________________");

int num = 0;

do
{
    Console.WriteLine(num);
    num--;
} while (num > 0);

Console.WriteLine("________________");

while (num < 70)
{
    Console.WriteLine(num);
    num++;
}

Console.WriteLine("________________");

for (int i = 0; i < num; i++)
{
    Console.WriteLine("Total Schizo Victory");
}

Console.WriteLine("________________");

int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}
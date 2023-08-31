using SEShellBasicPrograms;
using SEShellProgram;

//default constructor
//Calculations calculations = new Calculations();

/*
Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

//parameterised constructor
Calculations calculations = new
                        Calculations(number1, number2);

int ans = calculations.Addition();

Console.WriteLine(ans);
*/

//Encapsulation and Access Modifier
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());



// parametrised constructor
#pragma warning disable CS8604 // Possible null reference argument.
StudentDetails studentDetails = new StudentDetails(rollno, name,address, phno);
#pragma warning restore CS8604 // Possible null reference argument.

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name); 
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);


// Inheritance
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, mark1, mark2, mark3);
Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Phno);

studentMarks.CalculateScores();



//ML Inheritance

int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentGrades studentGrades = new StudentGrades(rollno,name,address,phno,mark1,mark2,mark3, "");

studentGrades.CalculateTotal();
studentGrades.CalculateAverage();
studentGrades.CalculateGrade();

Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);

Console.WriteLine(studentGrades.CalculateTotal());
Console.WriteLine(studentGrades.CalculateAverage());
Console.WriteLine(studentGrades.CalculateGrade());


BankDetails bankDetails = new BankDetails(12345,986756767, "Venkateswar", "Inactive");

Console.WriteLine("1. Custid 2.Accno Name:");

int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        bankDetails.GetAccountDetails(12345);
        break;
    case 2:
        bankDetails.GetAccountDetails(986756767);
        break;
    case 3:
        bankDetails.GetAccountDetails("Venkateswar");
        break;
}
*/

Bikes olabike = new Bikes("Electric Bike", "2 Stroke", 2);
Bikes hero = new Bikes("Moter Bike", "3 Stroke", 2);

olabike.MakeSound("zzzzz");
hero.MakeSound("eeeee");

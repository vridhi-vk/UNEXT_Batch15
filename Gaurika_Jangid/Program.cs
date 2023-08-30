using ConsoleApp1;
using SimplePrograms;

//default constructor
//Calculations calculations = new Calculations();

/*
Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

//parameterised constructor
Calculations calculations = new Calculations(number1, number2);

int ans = calculations.Addition();

Console.WriteLine(ans);
*/


/*
// Encapsulation and Access Modifier
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();    
long phno = Convert.ToInt64(Console.ReadLine());

// parameterised constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/




/*
// Single Inheritance
int rollno = Convert.ToInt32(Console.ReadLine());
string? name =  Console.ReadLine();
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

*/




/*
// ML inheritance
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentGrades studentGrades = new StudentGrades(rollno, name, address, phno, mark1, mark2, mark3, "");



Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);

Console.WriteLine(studentGrades.CalculateTotal());
Console.WriteLine(studentGrades.CalculateAverage());
Console.WriteLine(studentGrades.CalculateGrade());
*/



/*
// Method Overloading
BankDetails bankDetails = new BankDetails(1234, 90799748594l, "Mia", "Inactive");

bankDetails.WelcomeMessage();

Console.WriteLine("1. Custid 2. Accno 3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        bankDetails.GetAccountDelails(1234);
        break;
    case 2:
        bankDetails.GetAccountDelails(9079974859L);
        break;
    case 3:
        bankDetails.GetAccountDelails("Mia");
        break;
}
*/





/*


// Method Overridding
UpdateBankDetails updateBankDetails = new UpdateBankDetails(1234, 90799748594l, "Mia", "Inactive");

updateBankDetails.WelcomeMessage();

Console.WriteLine("1. Custid 2. Accno 3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        updateBankDetails.GetAccountDelails(1234);
        break;
    case 2:
        updateBankDetails.GetAccountDelails(9079974859L);
        break;
    case 3:
        updateBankDetails.GetAccountDelails("Mia");
        break;
}
*/





/*
Bikes olabike = new Bikes("Electric Bike", "2 Stroke", 2);
Bikes hero = new Bikes("Moter Bike", "3 Stroke", 2);

olabike.MakeSound("zzzzz");
hero.MakeSound("eeeee");

*/




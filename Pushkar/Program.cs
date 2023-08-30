//using SimplePrograms;

////default constructor
////Calculations calculations = new Calculations();


//Console.WriteLine("Enter 2 numbers");
//double number1 = Convert.ToDouble(Console.ReadLine());
//double number2 = Convert.ToDouble(Console.ReadLine());

////parameterised constructor
//Calculations calculations = new
//                        Calculations(number1, number2);

//int ans = calculations.Addition();

//Console.WriteLine(ans);

using SamplePrograms;
using System.Net.Sockets;
/*
// encapsulation and Access Modifiers
int rollno=Convert.ToInt32(Console.ReadLine());
string? name=Console.ReadLine();
string? address=Console.ReadLine();
long phno=Convert.ToInt64(Console.ReadLine());

//parameterized constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name); 
Console.WriteLine(studentDetails.Address);  
Console.WriteLine(studentDetails.Phno);
*/
/*
// Single Inheritance
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int  mark1=Convert.ToInt32(Console.ReadLine());
int  mark2=Convert.ToInt32(Console.ReadLine()); 
int  mark3=Convert.ToInt32(Console.ReadLine());

//parameterized constructor
StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, mark1, mark2, mark3);

Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Phno);
*/
//studentMarks.CalculateScores();

// Multi level Inheritance
/*int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentGrades studentGrades = new StudentGrades(rollno, name, address, phno, 
    mark1, mark2, mark3 ,"");
Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);

Console.WriteLine(studentGrades.CalculateTotal());
Console.WriteLine(studentGrades.CalculateAverage());
Console.WriteLine(studentGrades.CalculateGrade());  
*/

/*
// Method overloading
BankDetails bankDetails = new BankDetails(12345, "john doe",9876543221,"Inactive");

bankDetails.WelcomeMessage();
Console.WriteLine(" 1 Custid, 2 Accno, 3 Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        bankDetails.GetAccountDetails(12345);
        break;
    case 2:
        bankDetails.GetAccountDetails(9876543221);
        break;
    case 3:
        bankDetails.GetAccountDetails("john doe");
        break;
}

*/

// Method overiding
UpdateBankDetails updatebankDetails = new UpdateBankDetails(12345, "john doe", 9876543221, "Inactive");

updatebankDetails.WelcomeMessage();
Console.WriteLine(" 1 Custid, 2 Accno, 3 Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        updatebankDetails.GetAccountDetails(12345);
        break;
    case 2:
        updatebankDetails.GetAccountDetails(9876543221);
        break;
    case 3:
        updatebankDetails.GetAccountDetails("john doe");
        break;
}
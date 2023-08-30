using SimplePrograms;

//default constructor
//Calculations calculations = new Calculations();

/*Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

//parameterised constructor
Calculations calculations = new
                        Calculations(number1, number2);

int ans = calculations.Addition();

Console.WriteLine(ans);
*/




// Encapsulation & access Modifiers
/*int rollno = Convert.ToInt32(Console.ReadLine());
string name = Console.ReadLine();
string address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/




//Inheritance         Create object only for derived class
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());


int marks1 = Convert.ToInt32(Console.ReadLine());           
int marks2 = Convert.ToInt32(Console.ReadLine());
int marks3 = Convert.ToInt32(Console.ReadLine());

StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, marks1, marks2, marks3);

Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Phno);

studentMarks.CalculateScores();*/




//ML Inheritance
/*int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());


int marks1 = Convert.ToInt32(Console.ReadLine());
int marks2 = Convert.ToInt32(Console.ReadLine());
int marks3 = Convert.ToInt32(Console.ReadLine());

StudentGrades studentGrades = new StudentGrades(rollno, name, address, phno, marks1, marks2, marks3, "");

Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);

Console.WriteLine(studentGrades.CalculateTotal());
Console.WriteLine(studentGrades.CalculateAverage());
Console.WriteLine(studentGrades.CalculateGrade());

*/

//METHOD OVERLOADING

/*BankDetails bankDetails = new BankDetails(1234, 3325645645, "Yog", "Inactive");

bankDetails.WelcomeMessage();
Console.WriteLine("1. Custid  2. Accno  3.Name");



int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        bankDetails.GetAccountDetails(1234);
        break;

    case 2:
        bankDetails.GetAccountDetails(3325645645);
        break;
    case 3:
        bankDetails.GetAccountDetails("Yog");
        break;
    case 4:
        bankDetails.GetAccountDetails("Inactive");
        break;

} */



//METHOD OVERRIDDING
/*
UpdateBankDetails updatebankDetails = new UpdateBankDetails(1234, 3325645645, "Yog", "Inactive");

updatebankDetails.WelcomeMessage();
Console.WriteLine("1. Custid  2. Accno  3.Name");



int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        updatebankDetails.GetAccountDetails(1234);
        break;

    case 2:
        updatebankDetails.GetAccountDetails(3325645645);
        break;
    case 3:
        updatebankDetails.GetAccountDetails("Yog");
        break;
    case 4:
        updatebankDetails.GetAccountDetails("Inactive");
        break;

} */
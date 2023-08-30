using SamplePrograms;

int custid = 00010;
long accno = 123456789012345;
string? name = "Jadu";
string? status = "Banned";

UpdateBankDetails updateBankDetails = new UpdateBankDetails(00010, 123456789012345, "Jadu", "Banned");

updateBankDetails.WelcomeMessage();
Console.WriteLine("1. Custid \n2. Account no\n3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        updateBankDetails.GetAccountDetails(custid);
        break;
    case 2:
        updateBankDetails.GetAccountDetails(accno);
        break;
    case 3:
        updateBankDetails.GetAccountDetails(name);
        break;

    default: break;
}
/*
// Multilevel Inheritance
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
// Single Inheritance
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());


int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2= Convert.ToInt32(Console.ReadLine());
int mark3= Convert.ToInt32(Console.ReadLine());

StudentMarks studentMarks =new StudentMarks(rollno, name, address, phno, mark1, mark2, mark3);   

Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Phno);
studentMarks.CalculateAverage();
*/

/*
// Encapsulation
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

// parameterized constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);


Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/

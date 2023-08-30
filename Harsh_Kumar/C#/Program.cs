//using SimplePrograms;

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

Console.WriteLine(ans);*/

using SEPrograms;
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string name = Console.ReadLine();
string address = Console.ReadLine();
long phno  = Convert.ToInt64(Console.ReadLine());

//parameterized constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);
Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/

/*
 
int rollno = Convert.ToInt32(Console.ReadLine());
string name = Console.ReadLine();
string address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, mark1, mark2, mark3);

Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Phno);
Console.WriteLine(studentMarks.Mark1);
Console.WriteLine(studentMarks.Mark2);
Console.WriteLine(studentMarks.Mark3);
*/

int rollno = Convert.ToInt32(Console.ReadLine());
string name = Console.ReadLine();
string address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentGrades studentGrades = new StudentGrades(rollno, name, address, phno, mark1, mark2, mark3, "");

Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);
Console.WriteLine(studentGrades.Mark1);
Console.WriteLine(studentGrades.Mark2);
Console.WriteLine(studentGrades.Mark3);
Console.WriteLine(studentGrades.CalculateTotal());
Console.WriteLine(studentGrades.CalculateAvg());
Console.WriteLine(studentGrades.CalculateGrade());


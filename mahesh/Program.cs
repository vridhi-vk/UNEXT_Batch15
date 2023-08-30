// See https://aka.ms/new-console-template for more information
using SimplePrograms;

Console.WriteLine("Hello, World!");

//Encapsulation Skipped

//Inheritance

int rollNo = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phNum = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

//StudentMarks studentMarks = new StudentMarks(rollNo, name, address, phNum,
//    mark1, mark2, mark3);

//studentMarks.CalcScores();

StudentGrades studentGrades = new StudentGrades(rollNo, name, address,
    phNum, mark1, mark2, mark3);

Console.WriteLine("RollNo is " + studentGrades.Rollno);
Console.WriteLine("Name is " + studentGrades.Name);
Console.WriteLine("Address is " + studentGrades.Address);
Console.WriteLine("PhNum is " + studentGrades.PhoneNo);

Console.WriteLine("Mark1 is " + studentGrades.Mark1);
Console.WriteLine("Mark2 is " + studentGrades.Mark2);
Console.WriteLine("Mark3 is " + studentGrades.Mark3);

Console.WriteLine();

Console.WriteLine("Total Marks: " + studentGrades.CalculateTotal());
Console.WriteLine("Average Marks: " + studentGrades.CalculateAverage());
Console.WriteLine("Grade: " + studentGrades.CalculateGrade());

// See https://aka.ms/new-console-template for more information
using SimplePrograms;
using SimplePrograms.Assignment.Assignment_1;

Console.WriteLine("Hello, World!");

//Encapsulation Skipped

//Inheritance
/*
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
*/

//Below is ABSTRACTIONS
//Bike electricBike = new Bike("elec", "elec", 2);
//Bike someBike = new Bike("petrol", "bad engine", 20);

//electricBike.MakeSound("no sound");
//someBike.MakeSound("bad sound");

//Below is EXCEPTIONS
/*
try
{
    BankAccount account = new BankAccount("1234567890", 1000);
    Console.WriteLine($"Account Number: {account.GetAccountNumber()}, Balance: {account.GetBalance()}");

    account.Withdraw(500);
    Console.WriteLine($"Withdraw 500, Balance: {account.GetBalance()}");

    account.Deposit(200);
    Console.WriteLine($"Deposit 200, Balance: {account.GetBalance()}");

    account.Withdraw(2000);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}
*/

//Assignment 1
Animal animal = new Animal("animal name", 10);
Dog dog = new Dog("Dog name", 8);
Cat cat = new Cat("Cat name", 7);
Bird bird = new Bird("Bird name", 5);

animal.MakeSound();
dog.MakeSound();
cat.MakeSound();
bird.MakeSound();


using SimplePrograms;
/*
//default constructor
//Calculations calculations = new Calculations();


Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

//parameterised constructor
Calculations calculations = new
                        Calculations(number1, number2);

int ans = calculations.Addition();

Console.WriteLine(ans);
*/


int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

// parameterised constructor
#pragma warning disable CS8604 // Possible null reference argument.
StudentDetails studentdetails = new StudentDetails(rollno,
    name, address, phno);
#pragma warning restore CS8604 // Possible null reference argument.

Console.WriteLine(studentdetails.Rollno);
Console.WriteLine(studentdetails.Name);
Console.WriteLine(studentdetails.Address);
Console.WriteLine(studentdetails.Phno);


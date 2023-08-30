using SamplePrograms;


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


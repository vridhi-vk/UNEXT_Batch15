using Assignment;

/*
Animal animal = new Animal(23, "OOOO");
Console.WriteLine(animal.Age);
Console.WriteLine(animal.Name);
animal.MakeSound();
*/

/*
Dog dog = new Dog(10, "Rambo");
Console.WriteLine(dog.Age);
Console.WriteLine(dog.Name);
dog.MakeSound();
*/

/*
Shape shape = new Shape("Square");
shape.GetInfo();
*/

/*
Console.WriteLine("Enter area of Rectangle : ");
double area = Convert.ToDouble(Console.ReadLine());
Rectangle rectangle = new Rectangle("Rectangle", area);
rectangle.GetInfo("Rectangle", area);
*/

Console.WriteLine("Enter radius of Circle : ");
double radius = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle("Circle", radius);
circle.GetInfo("Circle", radius);
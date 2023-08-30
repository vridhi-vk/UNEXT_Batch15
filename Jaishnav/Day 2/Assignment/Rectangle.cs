using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : Shape
    {
        double area;
        public Rectangle(string? name, double area) : base(name)
        {
        }

        public new void GetInfo(string name, double area)
        {
            Console.WriteLine("Area of " + name + " : " + area);
        }
    }
}

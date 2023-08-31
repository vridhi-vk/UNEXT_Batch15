using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : Shape
    {
        public Circle(string? name, double radius) : base(name)
        {
        }

        public void GetInfo(string? name, double radius)
        {
            Console.WriteLine("Radius of " + name + " : " + radius);
        }
    }
}

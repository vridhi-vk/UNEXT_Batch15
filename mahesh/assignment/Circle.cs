using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Assignment.Assignment_2
{
    internal class Circle: Shape
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(string name, double radius): base(name)
        {
            Radius = radius;
        }

        public new void GetInfo()
        {
            Console.WriteLine("This is a circle. Radius is " + Radius + "\nArea is " + CalculateArea());
        }

        public double CalculateArea()
        {
            return double.Pi * Radius * Radius;
        }
    }
}

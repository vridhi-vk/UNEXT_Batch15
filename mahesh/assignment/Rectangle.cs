using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Assignment.Assignment_2
{
    internal class Rectangle: Shape
    {
        private double length, bredth;

        public Rectangle(string name, double length, double bredth): base(name)
        {
        }

        public double Length { get => length; set => length = value; }
        public double Bredth { get => bredth; set => bredth = value; }

        public new void GetInfo()
        {
            Console.WriteLine("This is a rectangle. " +
                "The length is " + Length + "\nBredth is " + Bredth + "\nArea is " + CalculateArea());
        }

        public double CalculateArea()
        {
            return Length*Bredth;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Circle
    {
        double area;

        public Circle(double r,string name)
        {
            this.area = 3.14*r*r;
        }

        public double GetInfo()
        {
            return this.area;
        }
    }
}

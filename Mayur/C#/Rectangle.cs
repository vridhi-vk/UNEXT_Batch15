using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Rectangle
    {
        double area;

        public Rectangle(double l,double b,string name)
        {
            this.area = l*b;
        }

        public double GetInfo()
        {
            
            return area;
        }
    }
}

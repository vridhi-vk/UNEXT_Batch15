using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Rectangle: Shape
    {
        private int area;

        public Rectangle(string? name, int area) : base(name)
        {
            Area = area;
        }

        public int Area { get => area; set => area = value; }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Area);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Circle: Shape
    {
        int radius;

        public Circle(string? name, int radius) : base(name)
        {
            Radius = radius;
        }

        public int Radius { get => radius; set => radius = value; }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Radius);
        }
    }
}

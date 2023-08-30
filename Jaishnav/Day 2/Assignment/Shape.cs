using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Shape
    {
        string? name;

        public Shape(string? name)
        {
            Name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine("Random Info");
        }

        public string? Name { get => name; set => name = value; }
    }
}

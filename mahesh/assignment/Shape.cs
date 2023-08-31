using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Assignment.Assignment_2
{
    internal class Shape
    {
        private string? name;

        public Shape(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }

        public void GetInfo()
        {
            Console.WriteLine("this is a generic shape");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Dog : Animal
    {
        public Dog (int age,  string? name) : base (age, name)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine("Boww Boww!");
        }
    }
}

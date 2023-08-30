using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Assignment.Assignment_1
{
    internal class Bird: Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public new void MakeSound()
        {
            Console.WriteLine("bird says TWEET TWEET");
        }
    }
}

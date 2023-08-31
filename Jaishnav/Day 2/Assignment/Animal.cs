using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Animal
    {
        int age;
        string? name;

        public Animal(int age, string? name)
        {
            Age = age;
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Burrrr");
        }

        public int Age { get => age; set => age = value; }
        public string? Name { get => name; set => name = value; }
    }

   
}

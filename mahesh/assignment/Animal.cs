using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.Assignment.Assignment_1
{
    internal class Animal
    {
        private string? name;
        private int age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void MakeSound()
        {
            Console.WriteLine("animal says generic animal sounds ooooo");
        }
    }
}

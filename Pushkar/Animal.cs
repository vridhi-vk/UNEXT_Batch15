using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Animal: IAnimal
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

        public void MakeSound(string name)
        {
            switch (name)
            {
                case "Dog":
                    Console.WriteLine("Woof");
                    break;
                case "Cat":
                    Console.WriteLine("Meow");
                    break;
                case "Bird":
                    Console.WriteLine("caw");
                    break;

               
            }
        }
    }


}

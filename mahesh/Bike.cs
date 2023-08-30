using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Bike : IBikes
    {
        private string? name, engineType;
        private int wheels;

        public Bike(string name, string engineType, int wheels)
        {
            Name = name;
            EngineType = engineType;
            Wheels = wheels;
        }

        public string Name { get => name; set => name = value; }
        public string EngineType { get => engineType; set => engineType = value; }
        public int Wheels { get => wheels; set => wheels = value; }

        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}

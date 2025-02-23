using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SimplePrograms
{
    // single Inheritance childClass : parentClass
    internal class StudentMarks : StudentDetails
    {
        private int mark1, mark2, mark3;



        public StudentMarks(int rollno, string name, string address, long phno, int mark1,
            int mark2, int mark3) :
            base(rollno, name, address, phno)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }



        // Encapsulation - properties
        public int Mark1 { get => mark1; set => mark1 = value; }
        public int Mark2 { get => mark2; set => mark2 = value; }
        public int Mark3 { get => mark3; set => mark3 = value; }



        // Methods
        public int CalculateTotal()
        {
            int total = Mark1 + Mark2 + Mark3;
            return total;
        }

        public double CalculateAverage()
        {
            int total = Mark1 + Mark2 + Mark3;
            double avg = total / 3;
            return avg;
        }

    }
}

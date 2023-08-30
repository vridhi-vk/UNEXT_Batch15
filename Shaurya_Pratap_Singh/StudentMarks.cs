using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentMarks : StudentDetails
    {
        private int Mark1, Mark2, Mark3;

        public StudentMarks(int rollno, string name, string address, long phno, int mark1, int mark2, int mark3) : base(rollno, name, address, phno)
        {
            Mark11 = mark1;
            Mark21 = mark2;
            Mark31 = mark3;

        }

        public int Mark11 { get => Mark1; set => Mark1 = value; }
        public int Mark21 { get => Mark2; set => Mark2 = value; }
        public int Mark31 { get => Mark3; set => Mark3 = value; }

        //Methods

        /*public void CalculatedScore()
        {
            //Using accesss via properties
            int total = Mark11 + Mark21 + Mark31;
            double avg = total / 3;
            Console.WriteLine(total+" "+avg);
        }*/

        public int CalculatedTotal()
        {
            //Using accesss via properties
            int total = Mark11 + Mark21 + Mark31;
            return total;
        }

        public double CalculatedAvg()
        {
            //Using accesss via properties
            double avg = (Mark11 + Mark21 + Mark31) / 3;
            return avg;
        }
    }
}

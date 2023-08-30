using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentGrades : StudentMarks
    {
        private string? grade;
        public StudentGrades(int rollno, string name, string address, long phno, int mark1, int mark2, int mark3, string grade) : base(rollno, name, address, phno, mark1, mark2, mark3)
        {
            Grade = grade;
        }

        public string Grade { get => grade; set => grade = value; }

        public void CalculateGrade()
        {
            double avg = CalculatedAvg();
            if (avg > 90)
            { 
                Grade="A Grade"; 
            }
            else if(avg >= 70 && avg<=89)
            {
                Grade = "B Grade";
            }
            else if(avg >=50 && avg<=69)
            {
                Grade = "C Grade";
            }
            else
            {
                Grade = "D Grade";
            }
            Console.WriteLine(Grade);
        }
    }
}

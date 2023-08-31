using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class StudentGrades : StudentMarks 
    {
        private string? grade;

       

        public StudentGrades(int rollno, string name, string address, long phno,int marks1,int marks2,int marks3, string grade)
            : base(rollno, name, address, phno, marks1, marks2, marks3)
        {
            Grade = grade;
        }

        public string? Grade { get => grade; set => grade = value; }

        public string CalculateGrade()
        {
            double avg = CalculateAverage();
            if(avg > 90)
            {
                Grade = "A";
            }

            else if(avg >=70 && avg <= 89)
            {
                Grade = "B";
            }

            else if (avg >= 50 && avg <= 69)
            {
                Grade = "C";
            }

            else { Grade = "D"; }

            return Grade;
        }
    }
}

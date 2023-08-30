using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal class StudentGrades : StudentMarks
    {
        private string? grade;

        public StudentGrades(int rollno, string name, string address,
            long phno, int mark1, int mark2, int mark3, string grade) 
            : base(rollno, name, address, phno, mark1, mark2, mark3)
        {
            Grade = grade; 
        }

        // property
        public string? Grade { get => grade; set => grade = value; }

        public string CalculateGrade()
        {
            double avgScore = CalculateAverage();
            
            if(avgScore > 90)
            {
                Grade = "A";
            }
            else if(avgScore >= 70 && avgScore <= 90)
            {
                Grade = "B";
            } 
            else if(avgScore >= 50 && avgScore <= 69)
            {
                Grade = "C";
            } 
            else
            {
                Grade = "D";
            }

            return Grade;
        }
    }
}

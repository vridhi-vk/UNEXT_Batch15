namespace SimplePrograms
{
    internal class StudentGrades : StudentMarks
    {
        private string? grade;

        public StudentGrades(int rollno, string name, string address, long phoneNo,
            int mark1, int mark2, int mark3) :
            base(rollno, name, address, phoneNo, mark1, mark2, mark3)
        {
            Grade = grade;
        }

        public string? Grade { get => grade; set => grade = value; }

        public string CalculateGrade()
        {
            double average = CalculateAverage();

            if (average == 100)
                Grade = "A+";
            else if (average > 90)
                Grade = "A";
            else
                Grade = "nope";

            return Grade;
        }

    }
}

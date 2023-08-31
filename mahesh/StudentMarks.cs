namespace SimplePrograms
{
    internal class StudentMarks : StudentDetails
    {
        private int mark1, mark2, mark3;

        public StudentMarks(int rollno, string name, string address, long phoneNo ,
            int mark1, int mark2, int mark3)
            : base(rollno, name, address, phoneNo)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        public int Mark1 { get => mark1; set => mark1 = value; }
        public int Mark2 { get => mark2; set => mark2 = value; }
        public int Mark3 { get => mark3; set => mark3 = value; }

        public void CalcScores()
        {
            int total = Mark1 + Mark2 + Mark3;
            Console.WriteLine("The name is " + Name);
            Console.WriteLine("Average is " + total/3);
        }

        public int CalculateTotal()
        {
            return mark1 + mark2 + mark3;
        }

        public double CalculateAverage()
        {
            return CalculateTotal() / 3;
        }
    }
}

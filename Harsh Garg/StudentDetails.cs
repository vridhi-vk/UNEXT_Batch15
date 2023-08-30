using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentDetails
    {
        private int rollno;
        private string? name, address; //Nullable strings
        private long phno;

        public StudentDetails(int rollno, string name, string address, long phno)
        {
            // Accessing the variables via property instead of direct access & this function

            Rollno = rollno;
            Name = name;
            Address = address;
            Phno = phno;
        }

        //Encapsulations of private fields as property
        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public long Phno { get => phno; set => phno = value; }
    }
}

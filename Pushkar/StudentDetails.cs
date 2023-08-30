using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal class StudentDetails
    { 
        //Access specifiers
        private int rollno;
        private string? name, address; //? means nullable string
        private long phno;

        public StudentDetails(int rollno, string name, string address, long phno)
        {
            this.Rollno = rollno;
            this.Name = name;
            this.Address = address;
            this.Phno = phno;
        }

        
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
        public long Phno { get => phno; set => phno = value; }
        public int Rollno { get => rollno; set => rollno = value; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class StudentDetails
    {

        //access specifiers need to be private 
        private int rollno;
        private string? name, address; //? to make it nullable string 
        private long phno;

        //encapsulation -> binding values together under a single name 
        public int Rollno { get => rollno; set => rollno = value; }

        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
        public long Phno { get => phno; set => phno = value; }

        public StudentDetails(int rollno, string name, string address, long phno)
        {
            Rollno = rollno;
            Name = name;
            Address = address;
            Phno = phno;
        }
    }
}
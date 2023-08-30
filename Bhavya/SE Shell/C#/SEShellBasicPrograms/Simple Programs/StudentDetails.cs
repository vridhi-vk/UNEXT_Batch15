using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Programs
{
    internal class StudentDetails
    {
        private int rollno;
        private string name, address;
        private string phno;
        
 

        public StudentDetails(int rollno, string name, string address, string phno)
        {
            Rollno = rollno;
            Name = name;
            Address = address;
            Phno = phno;
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phno { get => phno; set => phno = value; }
    }
}

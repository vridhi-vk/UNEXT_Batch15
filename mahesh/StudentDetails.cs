using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class StudentDetails
    {
        private int rollno;
        private string name, address;
        private long phoneNo;

        public StudentDetails(int rollno, string name, string address, long phoneNo)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.phoneNo = phoneNo;
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public long PhoneNo { get => phoneNo; set => phoneNo = value; }
    }
}

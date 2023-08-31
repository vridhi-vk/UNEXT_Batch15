using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal class BankDetails
    {
        private int custid;
        private string? name, status;
        private long accno;

        public BankDetails(int custid, string? name, long accno, string? status)
        {
            Custid = custid;
            Name = name;
            Accno = accno;
            Status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Status { get => status; set => status = value; }
        public void WelcomeMessage()
        {
            Console.WriteLine("Hello...");
        }


        public void GetAccountDetails(int custid)
        {
            if (Custid == custid)
            {
                Console.WriteLine(Accno+" "+Name+" "+Status);
            }
        }

        public void GetAccountDetails(long accno)
        {
            if (Accno == accno)
            {
                Console.WriteLine(Custid + " " + Name + " " + Status);
            }
        }

        public void GetAccountDetails(string name)
        {
            if (Name.Equals(name))
            {
                Console.WriteLine(Accno + " " + Custid + " " + Status);
            }
        }
    }
}

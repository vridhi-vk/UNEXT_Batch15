using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class BankDetails
    {
        private int custid;
        private long accno;
        private string? name,status;

        public BankDetails(int custid, long accno, string? name, String status )
        {
            this.custid = custid;
            this.accno = accno;
            this.name = name;
            this.status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string? Name { get => name; set => name = value; }
  
        public string? Status { get => name; set => name = value; }

        public void WelcomeMessage()
        {
            Console.WriteLine("Hello...");
        }

        public void GetAccountDetails(int custid)
        {
            if (Custid == custid)
            {
                Console.WriteLine(Accno + " " + Name + " " + Status);
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
            if (Name.Equals(name)
            {
                Console.WriteLine(Custid + " " + Accno + " " + Status);
                
            }

        }

    }
}

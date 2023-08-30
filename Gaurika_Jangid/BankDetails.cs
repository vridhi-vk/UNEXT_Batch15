using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankDetails
    {
        private int custid;
        private long accno;
        private string? name;
        private string? status;

        public BankDetails(long accno, string name)
        {
            Custid = custid;
            Accno = accno;
            Name = name;
            Status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public long? Accno { get => accno; set => accno = (long)value; }
        public string? Name { get => name; set => name = value; }
        public string? Status { get => status; set => status = value; }


        public void WelcomeMessage()
        {
            Console.WriteLine("Hello...");
        }

        public void GetAccountDelails(long accno)
        {
            if (Accno == accno)
            {
                Console.WriteLine(Custid + " " + Name + " " + Status);
            }
        }
        public void GetAccountDetails(string name)
        {
            if (name.Equals(name))
            {
                Console.WriteLine(Custid + " " + Accno + " " + Status);
            }
        }

        
    }
}

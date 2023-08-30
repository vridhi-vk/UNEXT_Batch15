using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal class UpdateBankDetails : BankDetails
    {
        public UpdateBankDetails(int custid, string? name, long accno, string? status) 
            : base(custid, name, accno, status)
        {
        }

        public new void WelcomeMessage()
        {
            Console.WriteLine("Howdy!!!");
        }
    }
}

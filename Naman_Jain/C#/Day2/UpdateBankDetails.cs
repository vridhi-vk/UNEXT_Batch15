﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    internal class UpdateBankDetails : BankDetails
    {
        public UpdateBankDetails(int custid, long accno, string? name, string? status) 
            : base(custid, accno, name, status)
        {
        }

        public new void WelcomeMessage()
        {
            Console.WriteLine("Mere pyare desh vasiyon... ");
        }
    }
}

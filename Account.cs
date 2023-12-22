using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homeBanking
{
    internal class Account
    {
        public string accountNumber;
        public string accountOwner;
        public int money;
        public string cbu;

        public int cents;

        public Account(string AccountNumber, string AccontOwner)
        {
            accountNumber = AccountNumber;
            accountOwner = AccontOwner;
            money = 100;

            createCBU();
        }

        public string createCBU()
        {
            string cbu = "";
            int digit;
            for(int i = 0; i < 22; i++)
            {
                digit = new Random().Next(0, 9);
                Convert.ToString(digit);
                cbu += digit;
            }
           
            return cbu;
        }
    }
}

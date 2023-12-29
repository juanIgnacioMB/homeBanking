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
        private string accountNumber;
        private string accountOwner;
        private int money;
        private string cbu;

        public int cents;


        public string AccountNumber
        {
            get { return accountNumber; }
            
        }

        public string AccountOwner
        {
            get { return accountOwner; }
             
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
              
        }

        public string CBU
        {
            get { return cbu; }
              
        }

        public Account(string AccountNumber, string AccontOwner, int Money)
        {
            accountNumber = AccountNumber;
            accountOwner = AccontOwner;
            money = Money;

            cbu = createCBU();
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

        public void showInformation()
        {
            Console.WriteLine("\nAccount owner: " + accountOwner +
                                        " \nnumber: "+ accountNumber +
                                        " \navailable founds: " + money +
                                        " \nCBU: " + cbu);
        }
    
    
         
    
    }


}

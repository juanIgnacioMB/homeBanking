using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeBanking
{
    internal class AccountManager
    {
        List<Account> accountsList = new List<Account>();

        public void createAccount(string AccountNumber, string AccontOwner, int Money)
        {
            Account NAccount = new Account(AccountNumber, AccontOwner, Money);

            accountsList.Add(NAccount);
            Console.WriteLine("Account created successfully!\n");
        }

        public void operateInAccount(string accountNumber)
        {
             
             
            for (int i = 0; i < accountsList.Count; i++)
            {
                //Console.WriteLine(accountsList.Count);
                if (accountsList[i].AccountNumber.Equals(accountNumber))
                {
                    Console.WriteLine("I find the account " + accountsList[i].AccountNumber);
                }
                else
                {
                    Console.WriteLine("I DIDN`T find the account " + accountsList[i].AccountNumber);
                }
            }
        }
    }
}

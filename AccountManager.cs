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



        public bool DoesTheAccountExist(string accountNumber)
        {

            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountNumber.Equals(accountsList[i].AccountNumber))
                {
                    return true;
                }
            }
            return false;

        }


        public void createAccount(string AccountNumber, string AccontOwner, int Money)
        {
            if (!DoesTheAccountExist(AccountNumber))
            {
                Account NAccount = new Account(AccountNumber, AccontOwner, Money);

                accountsList.Add(NAccount);
                Console.WriteLine("Account created successfully!\n");
            }
            else
            {
                Console.WriteLine("The account already exists, please try another number");
            }
            
        }

        public void operateInAccount(string accountNumber)
        {
            int counter = 0;    
             
            for (int i = 0; i < accountsList.Count; i++)
            {
               
                if (accountsList[i].AccountNumber.Equals(accountNumber))
                {
                    Console.WriteLine("I find the account " + accountsList[i].AccountNumber);
                }
                else
                {
                    counter++;
                }
            }

            if (counter == accountsList.Count){
                Console.WriteLine("Can`t find the account, check the number please");
            }
        }

       
    }
}

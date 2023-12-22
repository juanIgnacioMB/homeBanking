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
            Console.WriteLine("Account created with succes!");
        }
    }
}

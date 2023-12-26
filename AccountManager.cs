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


        public void createAccount()
        {

            Console.WriteLine("Enter account owner`s name");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter account number");
            string accountNumber = Console.ReadLine();

            Console.WriteLine("\nEnter money");
            int money = Convert.ToInt32(Console.ReadLine());
            {
                if (!DoesTheAccountExist(accountNumber))
                {
                    Account NAccount = new Account(accountNumber, name, money);

                    accountsList.Add(NAccount);
                    Console.WriteLine("Account created successfully!\n");
                }
                else
                {
                    Console.WriteLine("The account already exists, please try another number");
                }

            }
        }

        public void operateInAccount(string accountNumber)
        {
            int counter = 0;
            int flag = 0;
            for (int i = 0; i < accountsList.Count; i++)
            {
               
                if (accountsList[i].AccountNumber.Equals(accountNumber))
                {

                    while (flag == 0)
                    {
                        Console.WriteLine("Select an operation with a number");

                        Console.WriteLine("\n1 - transfer\n" +
                            "2 - Show account's information\n" +
                            "3 - Delete account\n" +
                            "4 - Exit");

                        string sel = Console.ReadLine();
                        int select;

                        

                        if(!(Int32.TryParse(sel, out select)) ||select > 4 || select < 0)
                        {
                            Console.WriteLine("Invalid, please choose a valid option");
                        }
                        else
                        {
                            switch (select)
                            {
                                case 1:
                                    Console.WriteLine("Transfer");
                                    break;
                                case 2:
                                    accountsList[i].showInformation();
                                    break;
                                case 3:
                                    Console.WriteLine("Account Deleted");
                                    break;
                                case 4:
                                    flag = 1;
                                    break;
                            }
                        }
                    }
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



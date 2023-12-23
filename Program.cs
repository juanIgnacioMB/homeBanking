// See https://aka.ms/new-console-template for more information

using homeBanking;

namespace Homebanking
{
     class Program
    {
        public static void Main()
        {
            int flag = 0;
            AccountManager bank = new AccountManager();

           



            while (flag != 1)
            {

                Console.WriteLine("Select an option with a number");
                Console.WriteLine("1 - Enter account\n" +
                                 "2 - Create account\n" +
                                 "3 - Delete account\n" +
                                 "4 - End");

                int choice = Convert.ToInt32(Console.ReadLine());



                while (choice <= 0 || choice >= 5)
                {
                    Console.WriteLine("invalid option, please try again\n");

                    Console.WriteLine("1 - Enter account\n" +
                                      "2 - Create account\n" +
                                      "3 - Delete account\n" + 
                                      "4 - End\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                }


                /*----------------------------------*/



                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter account`s number");
                        string number = Console.ReadLine();
                        bank.operateInAccount(number);

                        break;
                    case 2:
                        Console.WriteLine("Enter account owner`s name");
                        string name = Console.ReadLine();

                        Console.WriteLine("\nEnter account number");
                        string accountNumber = Console.ReadLine();

                        Console.WriteLine("\nEnter money");
                        int money = Convert.ToInt32(Console.ReadLine());

                        bank.createAccount(accountNumber, name, money);
                        break;
                    case 3:
                        Console.WriteLine("Choice 3");
                        break;
                    case 4:
                        flag = 1;
                        break;

                }


            }
                




        }

    }
}

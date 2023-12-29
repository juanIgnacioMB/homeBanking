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
                                 "3 - End");

                string choice = Console.ReadLine();
                int choiseInt;

                if (!(Int32.TryParse(choice, out choiseInt)) || choiseInt <= 0 || choiseInt >= 5)
                {
                    Console.WriteLine("invalid option, please try again\n");
                }
                else
                {
                    switch (choiseInt)
                    {
                        case 1:
                            Console.WriteLine("Enter account`s number");
                            string number = Console.ReadLine();
                            bank.operateInAccount(number);

                            break;
                        case 2:
                       
                            bank.createAccount();
                            break;
                        case 3:
                            flag = 1;
                            break;

                    }


                }


            }
                

        }

    }
}

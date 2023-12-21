// See https://aka.ms/new-console-template for more information

using homeBanking;

namespace Homebanking
{
     class Program
    {
        public static void Main()
        {
            Account acc1 = new Account("nacho","123456");

            Console.WriteLine("Select an option with a number");
            Console.WriteLine("1 - Enter account\n" +
                             "2 - Create account\n" +
                             "3 - Delete account\n");

            int choice = Convert.ToInt32(Console.ReadLine());

           

            while (choice <= 0 || choice >= 4)
            {
                Console.WriteLine("invalid option, please try again\n");

                Console.WriteLine("1 - Enter account\n" +
                                  "2 - Create account\n" +
                                  "3 - Delete account\n");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Choice 1");
                    break;
                case 2:
                    Console.WriteLine("Choice 2");
                    break;
                case 3:
                    Console.WriteLine("Choice 3");
                    break;

            }






        }

    }
}

using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 2400.00M;
            Console.WriteLine("Welcome to Bank Name.");
            Console.WriteLine("How can we help you today?");
            Choices();

        }
        static void Choices()
        {
            try
            {
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();
                int chosen = Convert.ToInt32(choice);
                if (chosen == 1)
                {
                    decimal currentBalance = Balance(balance);
                    Console.WriteLine(currentBalance);
                }
                if (chosen == 2)
                {
                    Withdraw(balance);
                }
                if (chosen == 3)
                {
                    Deposit(balance);
                }
                if (chosen == 4)
                {
                    exit
                }
            }
            catch (Exception)
            {
                Console.WriteLine("We could not understand your selection, please try again.");
                Choices();
            }
        }
        static decimal Balance(decimal balance)
        {

        }
        static decimal Withdraw(decimal balance)
        {

        }
        static decimal Deposit(decimal balance)
        {

        }
    }
}

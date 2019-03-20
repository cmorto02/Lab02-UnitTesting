using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal balance = 2400.00M;
                Console.WriteLine("Welcome to Bank Name.");
                Console.WriteLine("How can we help you today?");
                decimal change = Choices(balance);
                balance += change;
                if (change != 0)
                {
                    Console.WriteLine($"Your balance is { balance}.");
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        static decimal Choices(decimal balance)
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
                    try
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        string withdrawal = Console.ReadLine();
                        decimal decimalWithdrawal = Convert.ToDecimal(withdrawal);
                        Withdraw(balance, decimalWithdrawal);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("I'm sorry, we could not understand your selection.");
                        Console.WriteLine("To return to the previous menu, or to exit, please type 'return' or 'exit', respectively.");
                        Console.WriteLine("How much would you like to withdraw?");
                        string withdrawal = Console.ReadLine();
                        if (withdrawal == "return")
                        {
                            Choices(balance);
                        }
                        if (withdrawal == "exit")
                        {
                            return 0;
                        }
                        else
                        {
                            decimal decimalWithdrawal = Convert.ToDecimal(withdrawal);
                            Withdraw(balance, decimalWithdrawal);
                        }
                    }
                }
                if (chosen == 3)
                {
                    Deposit(balance);
                }
                if (chosen == 4)
                {
                    return 0;
                }
            }
            catch (FormatException  e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("We could not understand your selection, please try again.");
                Choices(balance);
            }
 
        }
        static decimal Balance(decimal balance)
        {
            Console.WriteLine(balance);
            return 0;
        }
        public static decimal Withdraw(decimal balance, decimal withdrawal)
        {
            return balance - withdrawal;
        }
        static decimal Deposit(decimal balance)
        {

        }
    }
}

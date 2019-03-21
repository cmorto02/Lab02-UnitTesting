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
                Console.WriteLine("Welcome to NotABank.");
                Console.WriteLine("How can we help you today?");
                decimal newBalance = SwitchChoices(balance);
                balance = newBalance;
                Console.WriteLine("Would you like to do anything else?");
                SwitchChoices(balance);
            }
            catch (Exception)
            {
                Console.WriteLine("We are sorry, there was an error.");
            }
            finally
            {
                Console.WriteLine("Thank you for using NotABank");
            }
        }
        static decimal SwitchChoices(decimal balance)
        {
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1. View your balance.");
            Console.WriteLine("2. Make a withdrawal.");
            Console.WriteLine("3. Make a deposit.");
            Console.WriteLine("4. Exit.");
            string choice = Console.ReadLine();
            int option = Convert.ToInt16(choice);
            switch (option)
            {
                case 1:
                    decimal bal = Balance(balance);
                    return bal;
                case 2:
                    Console.WriteLine("How much would you like to withdraw?");
                    string withdrawal = Console.ReadLine();
                    decimal decimalWithdrawal = Convert.ToDecimal(withdrawal);
                    decimal withdrawn = Withdraw(balance, decimalWithdrawal);
                    return withdrawn;
                case 3:
                    Console.WriteLine("How much would you like to deposit?");
                    string depositing = Console.ReadLine();
                    decimal decimaldepositing = Convert.ToDecimal(depositing);
                    decimal deposited = Deposit(balance, decimaldepositing);
                    return deposited;
                case 4:
                    return 0;
                default:
                    Console.WriteLine("Im sorry we did not understand, please choose again.");
                    return 0;
            }
        }
        public static decimal Balance(decimal balance)
        {
            Console.WriteLine(balance);
            return balance;
        }
        public static decimal Withdraw(decimal balance, decimal withdrawal)
        {
            if (withdrawal>0)
            {
                decimal change = balance - withdrawal;
                Console.WriteLine($"Your new balance is {change}");
                return change;
            }
            else
            {
                Console.WriteLine("Please enter a positive number");
                SwitchChoices(balance);
                return 0;
            }
            
        }
        public static decimal Deposit(decimal balance, decimal deposit)
        {
            return 0;
        }
    }
}

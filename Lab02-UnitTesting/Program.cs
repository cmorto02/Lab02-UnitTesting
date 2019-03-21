using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 2400.00M;
            try
            {
                bool run = true;
                Console.WriteLine("Welcome to NotABank.");
                Console.WriteLine("How can we help you today?");
                while (run == true)
                {
                    decimal newBalance = Menu(balance);
                    if (newBalance == -1)
                    {
                        run = false;
                    }
                    balance = newBalance;
                }
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
        /// <summary>
        /// This method displays the selection menu and then through a switch statement displays the balance, calls methods, or exits the app.
        /// </summary>
        /// <param name="balance">this is the beginning balance declared at the beginning of Main.</param>
        /// <returns>Returns the new balance, or -1 to exit the while loop in Main.</returns>
        static decimal Menu(decimal balance)
        {
            Console.WriteLine("1. View your balance.");
            Console.WriteLine("2. Withdraw.");
            Console.WriteLine("3. Deposit.");
            Console.WriteLine("4. Exit.");
            Console.WriteLine("Please make a selection.");
            string selection = Console.ReadLine();
            int option = Convert.ToInt32(selection);
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Your balance is {balance}");
                    return balance;
                case 2:
                    try
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        string amount = Console.ReadLine();
                        decimal withdrawing = Convert.ToDecimal(amount);
                        decimal amountAfterWithdrawal = Withdraw(balance, withdrawing);
                        return amountAfterWithdrawal;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                case 3:
                    try
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        string amount2 = Console.ReadLine();
                        decimal depositing = Convert.ToDecimal(amount2);
                        decimal amountAfterDeposit = Deposit(balance, depositing);
                        return amountAfterDeposit;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                case 4:
                    return -1;
                default:
                    Console.WriteLine("I'm sorry, we did not understand your selection. Please try again");
                    return balance;
            }
        }
        /// <summary>
        /// This method determines whether you have enough funds or if the withdrawal amount is negative, if it is not and you have the funds, it subtracts the withdrawal amount from the balance and then returns the new balance.
        /// </summary>
        /// <param name="balance">This is declared in Main and subsequently modified by this and the deposit method.</param>
        /// <param name="amount">This is a user defined amount to withdraw.</param>
        /// <returns>Returns the new balance.</returns>
        public static decimal Withdraw(decimal balance, decimal amount)
        {
            if (balance>amount && amount>0)
            {
                Console.WriteLine($"Your new balance is {balance-amount}");
                return balance - amount;
            }
            else
            {
                Console.WriteLine("Im sorry, but the number you entered is invalid or larger than your available funds.");
                return balance;
            }
        }
        /// <summary>
        /// This method determines whether you are trying to deposit a negative, if you are not then it adds the deposit amount to the balance and then returns the new balance.
        /// </summary>
        /// <param name="balance">This is declared in Main and subsequently modified by this and the withdraw method.</param>
        /// <param name="amount">This is a user defined method to deposit.</param>
        /// <returns>Returns the new balance.</returns>
        public static decimal Deposit(decimal balance, decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Your new balance is {balance + amount}");
                return balance + amount;
            }
            else
            {
                Console.WriteLine("Im sorry, but the number you entered is invalid.");
                return balance;
            }
        }
    }
}

using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Deposit amount:");
            var couldParse = double.TryParse(Console.ReadLine(), out double amount);

            while (!couldParse)
            {
                Console.Write("Please enter a valid amount: ");
                couldParse = double.TryParse(Console.ReadLine(), out amount);
            }

            account.Deposit(amount);

            Console.WriteLine($"Your new balance is ${account.GetBalance()}");

            Console.ReadLine();
        }
    }
}


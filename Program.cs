using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var akoiAccount = new BankAccount();
            Console.WriteLine("How much would like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            akoiAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {akoiAccount.GetBalance()}");




        }
    }
}

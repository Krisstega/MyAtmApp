using System;
using System.Collections.Generic;
using System.Text;

namespace MyAtmApp
{
    public static class OperationsPrompt
    {
        public const decimal initialAmount = 20000;
        public static decimal amount;
        //public static decimal mainAccountBalance = initialAmount + amount;
        public static void CashDeposit()
        {
            
            Console.WriteLine("Please enter your deposit amount N:");
            var amount = Convert.ToDecimal(Console.ReadLine());
            var mainAccountBalance = amount + initialAmount;

            Console.WriteLine($"The sum of {amount} has been deposited to your account. your account balance is {mainAccountBalance} Naira only. Thank you.\n");

            ContOrExit.AnotherTransac();
           
        }

        // Withdrawal prompt method
        public static void Withdrawal()
        {
            Console.WriteLine("Please type an amount to withdraw");
            
            var amount = Convert.ToInt32(Console.ReadLine());
           var accountBalance = initialAmount - amount ;

            if (initialAmount < amount)
            {
                // Sets warning messsage in red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insufficient Funds\n");
                Console.ResetColor();
                Withdrawal();
            }
            else
            {
                Console.WriteLine($"You have successfully withdraw {amount}, your account balance is {accountBalance }");
            }
            ContOrExit.AnotherTransac();
        }

        // transfer prompt method
        public static void Transfer()
        {
            Console.WriteLine("Please enter amount you want to transfer N:");
            var amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter your destination account number, IN 10 DIGITS:");
            string accountNumber = Console.ReadLine();
            // line of code to ensure account number is equal to 10 digits.
            if(accountNumber.Length != 10)
            {
                //set warning message in red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING: Please enter account number in 10 digits");
                Console.ResetColor();
                Utility.EnterToContinue();
                Transfer();
                
            }
            Console.WriteLine("please enter destination Bank name");
            var bankName = Convert.ToString(Console.ReadLine());
            if(amount  > initialAmount)
            {
                //set warning message in red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your current balance is too low");
                Console.ResetColor();
                Utility.EnterToContinue();
                Transfer();
            }

            Console.WriteLine($"The sum of {amount} has been successfully transfered to {bankName} with account Number: {accountNumber}.\n");
            Console.WriteLine($" your current balance is {initialAmount - amount} ");

            ContOrExit.AnotherTransac();
        }

        // Account Balance method
        public static void AccountBalance()
        {
            Console.WriteLine($"Your account balance { initialAmount-amount } naira.");
            ContOrExit.AnotherTransac();
        }
    }
}

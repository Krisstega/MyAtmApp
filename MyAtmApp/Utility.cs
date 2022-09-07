using System;
using System.Collections.Generic;
using System.Text;

namespace MyAtmApp
{
   public static class Utility
    {
        public static void EnterToContinue()
        {
            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();
        }
        public static void EnterPin()
        {
            try
            {
                Console.WriteLine("please enter your pin");
                int pin = Convert.ToInt32(Console.ReadLine());
                if (pin.ToString().Length == 4)
                {
                    Console.WriteLine("Correct pin");
                }
                else
                {
                    Console.WriteLine("Incorrect pin, please enter a four digit pin ");
                    EnterPin();
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                EnterPin();
            }
        }

        // Sets App Menu Prompt
        public static void AtmPrompt()
        {
            Console.WriteLine("-------------------Please select an option below--------------------\n");
            Console.WriteLine("\n1.Cash Deposit");
            Console.WriteLine("\n2.Withdrawal");
            Console.WriteLine("\n3.Transfer");
            Console.WriteLine("\n4.Account Balance\n");

            Console.WriteLine("Enter an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                //cash deposit method
                Console.Clear();
                OperationsPrompt.CashDeposit();
            }
            else if(option == 2)
            {
                //withdrawal method here
                Console.Clear();
                OperationsPrompt.Withdrawal();
            }
            else if (option == 3)
            {
                //transfer method here
                Console.Clear();
                OperationsPrompt.Transfer();
            }
            else if(option == 4)
            {
                //Account balance method here
                Console.Clear();
                OperationsPrompt.AccountBalance();
                
            }
            else
            {
                Console.WriteLine("Invalid option");
                AtmPrompt();
            }
               
        }

    }
}

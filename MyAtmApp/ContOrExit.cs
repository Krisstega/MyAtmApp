using System;
using System.Collections.Generic;
using System.Text;

namespace MyAtmApp
{
   public static class ContOrExit
    { 
        public static void AnotherTransac()
        {
            try
            {
                Console.WriteLine("if you want to carry out another transaction press 0, else enter any other number to exit");
                int press = Convert.ToInt32(Console.ReadLine());
                if (press == 0)
                {
                    Console.Clear();
                    Utility.AtmPrompt();
                }
                else
                {
                    //sets goodbye message to yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n......Thank you for banking with us, Have a nice day!.....");
                    Console.ResetColor();

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}

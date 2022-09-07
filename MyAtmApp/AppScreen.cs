using System;
using System.Collections.Generic;
using System.Text;

namespace MyAtmApp
{
   public static class AppScreen
    {
       internal static void Welcome()
        {
            // clears the console
            Console.Clear();

            // sets title of the Console App
            Console.Title = "My Atm App";

            // sets the foreground color.
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Sets welcome message.
            Console.WriteLine("\n------------------------Welcome To Atm Bank------------------------\n");
            Console.WriteLine("Please insert your card");


        }

    }
}

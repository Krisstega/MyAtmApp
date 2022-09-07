using System;

namespace MyAtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
              AppScreen.Welcome();

              Utility.EnterToContinue();

              Utility.EnterPin();

              Utility.EnterToContinue();
              Console.Clear();

              Utility.AtmPrompt();

          
            
           
            
        }
    }
}

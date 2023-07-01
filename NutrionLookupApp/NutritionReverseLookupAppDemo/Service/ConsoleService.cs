using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Service
{
    public class ConsoleService
    {
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}

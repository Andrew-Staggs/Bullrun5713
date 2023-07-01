using Microsoft.Identity.Client;
using NutritionReverseLookupAppDemo.Models;
using NutritionReverseLookupAppDemo.Service;
using System;

namespace NutritionReverseLookupAppDemo
{
    internal class Program
    {


        static void Main(string[] args)
        {



            Program progam = new Program();
            progam.Run();


        }
        NutritionConsoleService nutritionConsoleService = new NutritionConsoleService();
        ConsoleService consoleService = new ConsoleService();
        public void Run()
        {
            bool isTrue = true;

            while (isTrue)

            {
                nutritionConsoleService.PrintMainMenu();
                int menuSelection = nutritionConsoleService.PromptForInteger("Please choose an option", 0, 2);



                if (menuSelection == 0)

                {
                   
                    //exit loop

                }




                if (menuSelection == 1)

                {

                    //go to nutrition Sub menu

                    nutritionConsoleService.NutritionInfoSubMenu();
                    break; 

                }

                if (menuSelection == 2)

                {
                    //go to restaurant sub menu to search by restaurant


                }



            }


        }


    }

}


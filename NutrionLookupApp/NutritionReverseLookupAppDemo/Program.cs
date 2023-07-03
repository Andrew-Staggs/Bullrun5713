using Microsoft.Identity.Client;
using NutritionReverseLookupAppDemo.Models;
using NutritionReverseLookupAppDemo.Service;
using System;
using System.Collections.Generic;


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
            //test menu and test data at project start
            Nutrition cheesburgerArbys = new Nutrition(500, 1, 28, 50, 130, 15, 1123.24, 37.45, false);
            Nutrition milkshakeMcd = new Nutrition(600, 1, 28, 40, 180, 75.6, 552.4, 27.43, false);
            Nutrition OrangeJuiceBobEvans = new Nutrition(90, 1, 0, 1, 35, 27, 85.6, 0.1, true);

            MenuItem item1 = new MenuItem("Arby's", "Cheeseburger", cheesburgerArbys);
            MenuItem item2 = new MenuItem("McDonalds", "Milkshake", milkshakeMcd);
            MenuItem item3 = new MenuItem("Bob Evans", "Orange Juice", OrangeJuiceBobEvans);


            List<MenuItem> testMenuList = new List<MenuItem>();
            testMenuList.Add(item1);
            testMenuList.Add(item2);
            testMenuList.Add(item3);

            MenuItems menuItemsTest = new MenuItems(testMenuList);
            //end test data

            bool isTrue = true;


            while (isTrue)

            {
                nutritionConsoleService.PrintMainMenu();
                int menuSelection = nutritionConsoleService.PromptForInteger("Please choose an option", 0, 2);



                if (menuSelection == 0)

                {

                    //exit loop
                    isTrue = false;


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



            bool subIstrue = true;

            while (subIstrue) // needs to be in method so it can loop back to the main menu

            {
                nutritionConsoleService.NutritionInfoSubMenu();


                int menuSelection = nutritionConsoleService.PromptForInteger("Please choose an option", 0, 9);
                Nutrition userNutrition = new Nutrition();
                MenuItems menuItems = new MenuItems();
                menuItems.PopulatedMenuItems = new List<MenuItem>();


                if (menuSelection == 1) //make sure to move console code to console service

                {
                    Console.Write("please enter calories: ");
                    userNutrition.Calories = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                    menuSelection = nutritionConsoleService.PromptForInteger("Please choose an option", 0, 9);

                }

                if (menuSelection == 2)

                {
                    Console.Write("please enter sugar in grams: ");
                    userNutrition.Sugar = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                    menuSelection = nutritionConsoleService.PromptForInteger("Please choose an option", 0, 9);
                }


                if (menuSelection == 9)

                {


                    nutritionConsoleService.PrintMenuItemsToConsole(menuItems);


                }

                if (menuSelection == 0)
                {
                    subIstrue = false;


                }





            }



        }


    }

}


using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using NutritionReverseLookupAppDemo.Models;
using NutritionReverseLookupAppDemo.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo
{
    public class UserInterface
    {

        NutritionConsoleService nutritionConsoleService = new NutritionConsoleService();
        ConsoleService consoleService = new ConsoleService();


        //end test data
        public void Run()
        {
            //test menu and test data at project start


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


                    SubMenu();


                }

                if (menuSelection == 2)

                {
                    //go to restaurant sub menu to search by restaurant


                }



            }


        }

        public void SubMenu()
        {
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


            bool subIstrue = true;






            nutritionConsoleService.NutritionInfoSubMenu();
            Nutrition userNutrition = new Nutrition();
            MenuItems menuItems = new MenuItems();
            menuItems.PopulatedMenuItems = new List<MenuItem>();
            while (subIstrue)


            {
               

                int menuSelection = nutritionConsoleService.PromptForInteger("Please choose an option", 0, 10);




                if (menuSelection == 1) //make sure to move console code to console service

                {

                    Console.Write("please enter calories: ");
                    userNutrition.Calories = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }

                if (menuSelection == 2)

                {
                   

                    Console.Write("please enter sugar in grams: ");
                    userNutrition.Sugar = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }


                if (menuSelection == 3)

                {


                    Console.Write("please enter total carobohydrates in grams: ");
                    userNutrition.TotalCarbohydrates = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }


                if (menuSelection == 4)

                {


                    Console.Write("please enter total carobohydrates in grams: ");
                    userNutrition.TotalFat = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }


                if (menuSelection == 5)

                {


                    Console.Write("please enter total carobohydrates in grams: ");
                    userNutrition.SaturatedFat = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }


                if (menuSelection == 6)

                {


                    Console.Write("please enter total protien in grams: ");
                    userNutrition.Protien = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }


                if (menuSelection == 7)

                {


                    Console.Write("please enter Sodium in mg: ");
                    userNutrition.Sodium = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }


                if (menuSelection == 8)

                {


                    Console.Write("please enter T (true) if gluten free or F (false) if not: ");
                    
                  string glutenValue = Console.ReadLine();
                    if (glutenValue == "T")
                    {
                        userNutrition.IsGlutenFree = true;
                    }

                    else if (glutenValue == "F")
                    {
                        userNutrition.IsGlutenFree = false;
                    }

                    else

                    {
                        throw new Exception("incorrect syntax, T for True or F for False");
                    }

                    Console.WriteLine("");

                    menuItems = menuItemsTest.MenuItemsByNutrition(userNutrition, menuItemsTest);


                }
                if (menuSelection == 9)

                {


                    nutritionConsoleService.PrintMenuItemsToConsole(menuItems);



                }

                if (menuSelection == 10) // reset list (ideally a method to reset the list)

                {

                    testMenuList.Clear();

                    testMenuList.Add(item1);
                    testMenuList.Add(item2);
                    testMenuList.Add(item3);

                }


                if (menuSelection == 0)

                {


                    subIstrue = false;



                }


            }







        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{
    public class MenuItems
    {

        public List<MenuItem> PopulatedMenuItems = new List<MenuItem>();

        public MenuItems()
        {


        }
        public MenuItems(List<MenuItem> menuItems)
        {

            PopulatedMenuItems = menuItems;

        }

        public List<MenuItem> RemoveMenuItem(MenuItem itemToRemove)
        {

            List<MenuItem> updatedMenuItems = PopulatedMenuItems;

            for (int i = 0; i < updatedMenuItems.Count; i++)

            {
                if (updatedMenuItems[i] == itemToRemove)
                {
                    updatedMenuItems.RemoveAt(i);

                }

            }

            return updatedMenuItems;

        }

        /// <summary>
        /// Takes in List of Menu Items and calories and Returns a new list of menu items where calories is less than or equal to the entered number.
        /// </summary>
        /// <param name="calories"></param>
        /// <returns></returns>
        public MenuItems MenuItemsByCalories(double? calories, MenuItems menuItems)
        {
            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.Calories >= calories)
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }

                //add to list of menu items


            }

            return updatedItems;
        }

        public MenuItems MenuItemsBySugar(double? sugar, MenuItems menuItems)
        {
            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.Sugar >= sugar)
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }

                //add to list of menu items


            }

            return updatedItems;
        }

        public List<MenuItem> MenuItemsBySodium(double? sodium, List<MenuItem> menuItems)
        {

            foreach (MenuItem item in menuItems)
            {
                if (sodium <= item.ItemNutritionInfo.Sodium)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }


            }

            return menuItems;
        }

        public List<MenuItem> MenuItemsByProtien(double? protien, List<MenuItem> menuItems)
        {

            foreach (MenuItem item in menuItems)
            {
                if (protien <= item.ItemNutritionInfo.Protien)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }

            }

            return menuItems;
        }

        public List<MenuItem> MenuItemsBySaturatedFat(double? saturatedFat, List<MenuItem> menuItems)
        {

            foreach (MenuItem item in menuItems)
            {
                if (saturatedFat <= item.ItemNutritionInfo.SaturatedFat)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }

            }

            return menuItems;
        }

        public List<MenuItem> MenuItemsByTotalFat(double? totalFat, List<MenuItem> menuItems)
        {

            foreach (MenuItem item in menuItems)
            {
                if (totalFat <= item.ItemNutritionInfo.TotalFat)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }

            }

            return menuItems;
        }


        public List<MenuItem> MenuItemsByCarbohydrates(double? carbohydrates, List<MenuItem> menuItems)
        {

            foreach (MenuItem item in menuItems)
            {
                if (carbohydrates <= item.ItemNutritionInfo.TotalCarbohydrates)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }

            }

            return menuItems;
        }


        public List<MenuItem> MenuItemsByIsGlutenFree(bool isGlutenFree, List<MenuItem> menuItems)
        {

            foreach (MenuItem item in menuItems)
            {
                if (isGlutenFree)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }

            }

            return menuItems;
        }
        /// <summary>
        ///  returns a list of menu items that meets all user search parameters. Filters the list of 
        ///  menu items list in the database based on selected nutrition values housed in the nutrition object. Checks to see if
        ///  certain parameters in the nutrition object have values and if so, calls the methods to filter based off those parameters. For example,
        ///  if the user selects to filter by Sugar and Calories, the nutritionSelections parameter will have values only for those two selections.
        ///  Then, it will call only those two methods to filter the menu items list and return a new list that meets those selections.
        ///  
        /// Note: the nutritionSelections object has nullable parameters so the user does not have to make selections for everything.
        /// </summary>
        /// <param name="nutritionSelections"></param>
        /// <param name="menuItems"></param>
        /// <returns></returns>
        public MenuItems MenuItemsByNutrition(Nutrition nutritionSelections, MenuItems menuItems)
        {
            MenuItems filteredMenuItems = menuItems;

            if (nutritionSelections.Calories != null)
            {

                filteredMenuItems = MenuItemsByCalories(nutritionSelections.Calories, filteredMenuItems);

            }


            //if (nutritionSelections.Sodium != null)
            //{

            //    filteredMenuItems = MenuItemsBySodium(nutritionSelections.Sodium, filteredMenuItems);

            //}

            if (nutritionSelections.Sugar != null)
            {

                filteredMenuItems = MenuItemsBySugar(nutritionSelections.Sugar, filteredMenuItems);

            }

            //if (nutritionSelections.Protien != null)
            //{

            //    filteredMenuItems = MenuItemsByProtien(nutritionSelections.Protien, filteredMenuItems);

            //}

            //if (nutritionSelections.IsGlutenFree)
            //{

            //    filteredMenuItems = MenuItemsByIsGlutenFree(nutritionSelections.IsGlutenFree, filteredMenuItems);


            //}

            return filteredMenuItems;

        }
    }
}

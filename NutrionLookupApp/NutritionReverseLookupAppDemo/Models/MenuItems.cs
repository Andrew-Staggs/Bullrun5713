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

        public MenuItems MenuItemsBySodium(double? sodium, MenuItems menuItems)
        {

            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.Sodium >= sodium)
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }

                //add to list of menu items


            }

            return updatedItems;
        }

        public MenuItems MenuItemsByProtien(double? protien, MenuItems menuItems)
        {

            MenuItems updatedItems = menuItems;

            bool reset = true;
            

            while (reset)
            {
                bool hasOccured = false;


                for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
                {
                   
                    if (PopulatedMenuItems[j].ItemNutritionInfo.Protien >= protien)
                    {
                        updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                        hasOccured = true;
                        j = menuItems.PopulatedMenuItems.Count - 1; 
                    }

                   
                    //add to list of menu items
                }

                if (!hasOccured)
                {
                    reset = false;

                }
            }

            return updatedItems;
        }

        public MenuItems MenuItemsBySaturatedFat(double? saturatedFat, MenuItems menuItems)
        {

            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.SaturatedFat >= saturatedFat)
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }

                //add to list of menu items


            }

            return updatedItems;
        }

        public MenuItems MenuItemsByTotalFat(double? totalFat, MenuItems menuItems)
        {


            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.TotalFat >= totalFat)
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }

                //add to list of menu items


            }

            return updatedItems;
        }


        public MenuItems MenuItemsByCarbohydrates(double? carbohydrates, MenuItems menuItems)
        {

            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.TotalCarbohydrates >= carbohydrates)
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }

                //add to list of menu items


            }

            return updatedItems;
        }


        public MenuItems MenuItemsByIsGlutenFree(bool isGlutenFree, MenuItems menuItems)
        {

            MenuItems updatedItems = menuItems;

            for (int j = 0; j < menuItems.PopulatedMenuItems.Count; j++)
            {
                if (PopulatedMenuItems[j].ItemNutritionInfo.IsGlutenFree != isGlutenFree) //removed item if not gluten free
                {
                    updatedItems.RemoveMenuItem(PopulatedMenuItems[j]);
                }



                //add to list of menu items


            }

            return updatedItems;


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


            if (nutritionSelections.Sodium != null)
            {

                filteredMenuItems = MenuItemsBySodium(nutritionSelections.Sodium, filteredMenuItems);

            }

            if (nutritionSelections.Sugar != null)
            {

                filteredMenuItems = MenuItemsBySugar(nutritionSelections.Sugar, filteredMenuItems);

            }

            if (nutritionSelections.Protien != null)
            {

                filteredMenuItems = MenuItemsByProtien(nutritionSelections.Protien, filteredMenuItems);

            }

            if (nutritionSelections.TotalFat != null)
            {

                filteredMenuItems = MenuItemsByProtien(nutritionSelections.TotalFat, filteredMenuItems);

            }

            if (nutritionSelections.SaturatedFat != null)
            {

                filteredMenuItems = MenuItemsByProtien(nutritionSelections.SaturatedFat, filteredMenuItems);

            }

            if (nutritionSelections.TotalCarbohydrates != null)
            {

                filteredMenuItems = MenuItemsByProtien(nutritionSelections.TotalCarbohydrates, filteredMenuItems);

            }

            if (nutritionSelections.IsGlutenFree)
            {

                filteredMenuItems = MenuItemsByIsGlutenFree(nutritionSelections.IsGlutenFree, filteredMenuItems);


            }

            return filteredMenuItems;

        }
    }
}

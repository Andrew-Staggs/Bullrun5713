using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{
    public class MenuItem
    { // menu item info. has a name, 
        public string RestaurantName { get; set; }
        public string ItemName { get; set; }

        public Nutrition ItemNutritionInfo { get; set; } = new Nutrition();

        List <MenuItem> menuItems = new List<MenuItem>();
        public MenuItem()
        {

        }
        public MenuItem (string itemName, string restaurantName, Nutrition itemNutritionInfo)
        {
            RestaurantName = restaurantName;

            ItemName = itemName;
            ItemNutritionInfo = itemNutritionInfo; 
        }


        public List<MenuItem> MenuItemsByCalories(double calories)
        { //RETURNS list of menu items where calories is less than or equal to the entered number.

          
            foreach (MenuItem item in menuItems)
            {
                if (calories <= item.ItemNutritionInfo.Calories)
                {
                    //add to list of menu items
                    menuItems.Add(item);

                }


            }

            return menuItems; 

        }
         

           

        }

    }
}

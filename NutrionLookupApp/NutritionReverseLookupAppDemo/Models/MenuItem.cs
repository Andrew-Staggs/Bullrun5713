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

     
        public MenuItem (string restaurantName,string itemName, Nutrition nutrition)
        {
            RestaurantName = restaurantName;
            ItemName = itemName;
            ItemNutritionInfo = nutrition; 

        }

    }
}




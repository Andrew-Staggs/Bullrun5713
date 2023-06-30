using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{
    public class Restaurant
    {// show each restaurant
        public string RestaurantName { get; }
        public Dictionary<MenuItem, Nutrition> MenuItems { get; set; }
         
        public Restaurant(string restaurantName)
        {
            RestaurantName = restaurantName; 

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{
    public class MenuItem
    { // menu item info. has a name, 
        public string RestaurantName { get; }
        public string ItemName { get; }

        public Nutrition ItemNutritionInfo { get; }


    }
}

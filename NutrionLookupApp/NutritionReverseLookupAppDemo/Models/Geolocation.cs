using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{
    public class Geolocation
    { //location for user and restaurants searched 

        public string UserLocation { get; set; }
        public string RestaurantName { get; set; }
        public double DistanceToClosestRestaurant { get; set; }


    }
}

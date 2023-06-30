using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{ // nutrition info class. Contains all nutrition info categories housed in database
    public class Nutrition
    {
        // parameters for each nutrition element. 

       public double Calories { get; }

        public double SaturatedFat { get; }

        public double TotalFat { get; }
        public double SodiumInMg { get; }

        public double TotalCarbohydrates { get; }

        public double Sugar { get; }
        
        public double Protien { get; }

        public bool IsGlutenFree { get; }
         

    }
}

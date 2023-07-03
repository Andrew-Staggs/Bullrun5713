using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{ // nutrition info class. Contains all nutrition info categories housed in database
    public class Nutrition
    {
        // parameters for each nutrition element. 

        // parameters are nullable as user has option to not enter anything on the console for their search
        public double ServingSize { get; set; }
        //not sure if servingsize should have a set

        public double? SaturatedFat { get; set; }

        public double? TotalFat { get; set; }
        public double? Sodium { get; set; }

        public double? TotalCarbohydrates { get; set; }

        public double? Sugar { get; set; }

        public double? Protien { get; set; }

        public bool IsGlutenFree { get; set; }

        //below is calories for single serving.
        public double? Calories { get; set; }

        //totalCalories is derived.
        public double? TotalCalories
        {
            get
            {
                return ServingSize * Calories;
            }


        }

        //total calories as a function of serving size only works if serving size is standardized such as to ounces or grams. Otherwise serving Size could be 0.5 sandwiches.  
        public Nutrition ()

        {

        }

    

        public Nutrition(double calories, double servingSize, double saturatedFat, double totalFat, double totalCarbohydrates, double sugar, double sodium, double protien, bool isGlutenFree)

        {
            ServingSize = servingSize;

            SaturatedFat = saturatedFat;
            Calories = calories;
            TotalFat = totalFat;
            Sodium = sodium;
            TotalCarbohydrates = totalCarbohydrates;
            Sugar = sugar;
            Protien = protien;
            IsGlutenFree = isGlutenFree;  


    }




}
}

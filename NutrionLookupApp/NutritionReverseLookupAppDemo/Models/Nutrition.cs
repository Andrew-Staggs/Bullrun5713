using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionReverseLookupAppDemo.Models
{ // nutrition info class. Contains all nutrition info categories housed in database
    public class Nutrition
    {
        // parameters for each nutrition element. 


        public double ServingSize { get; set; }
        //not sure if servingsize should have a set

        public double SaturatedFat { get; }

        public double TotalFat { get; }
        public double Sodium { get; }

        public double TotalCarbohydrates { get; }

        public double Sugar { get; }

        public double Protien { get; }

        public bool IsGlutenFree { get; }

        //below is calories for single serving.
        public double Calories { get; set; }

        //totalCalories is derived.
        public double TotalCalories
        {
            get
            {
                return ServingSize * Calories;
            }


        }

        //calories as a function of serving size only works if serving size is standardized such as to ounces or grams. Otherwise serving Size could be 0.5 sandwiches. Calories 
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

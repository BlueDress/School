using System;
using System.Collections.Generic;

namespace Calories_Counter
{
    public class Startup
    {
        public static void Main()
        {
            var ingredientCalories = new Dictionary<string, int>();

            ingredientCalories.Add("cheese", 500);
            ingredientCalories.Add("tomato sauce", 150);
            ingredientCalories.Add("salami", 600);
            ingredientCalories.Add("pepper", 50);

            var totalCalories = 0;
            var numberOfIngredients = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfIngredients; i++)
            {
                var input = Console.ReadLine();

                if (ingredientCalories.ContainsKey(input.ToLower()))
                {
                    totalCalories += ingredientCalories[input.ToLower()];
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}

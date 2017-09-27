using System;

namespace Cake_Ingredients
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfIngredients = 0;

            while (true)
            {
                var ingredient = Console.ReadLine();

                if (ingredient.Equals("Bake!"))
                {
                    Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    numberOfIngredients++;
                }
            }
        }
    }
}

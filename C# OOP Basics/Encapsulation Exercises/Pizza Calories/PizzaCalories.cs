using System;
using System.Collections.Generic;

namespace Pizza_Calories
{
    public class PizzaCalories
    {
        public static void Main()
        {
            var pizzas = new List<Pizza>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    try
                    {
                        var tokens = input.Split();
                        var pizzaName = tokens[1];
                        var numberOfToppings = int.Parse(tokens[2]);
                        var pizza = new Pizza(pizzaName, numberOfToppings);

                        tokens = Console.ReadLine().Split();
                        var flourType = tokens[1].ToLower();
                        var bakingTechnique = tokens[2].ToLower();
                        var doughWeight = double.Parse(tokens[3]);
                        var dough = new Dough(flourType, bakingTechnique, doughWeight);
                        pizza.Dough = dough;

                        for (int i = 0; i < numberOfToppings; i++)
                        {
                            tokens = Console.ReadLine().Split();
                            var toppingType = tokens[1].ToLower();
                            var toppingWeight = double.Parse(tokens[2]);
                            var topping = new Topping(toppingType, toppingWeight);
                            pizza.AddTopping(topping, i);
                        }

                        pizzas.Add(pizza);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                        break;
                    }
                }
            }

            foreach (var pizza in pizzas)
            {
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():f2} Calories.");
            }
        }
    }
}

using System;
using System.Linq;

namespace Food_Shortage
{
    internal class Engine
    {
        private BuyingOperationsController controller;

        internal Engine()
        {
            this.controller = new BuyingOperationsController();
        }

        internal void Run()
        {
            ReadData();
            Console.WriteLine(TotalAmountOfFoodPurchased());
        }

        private string TotalAmountOfFoodPurchased()
        {
            var totalAmountOfFoodPurchased = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    if (this.controller.Buyers.ContainsKey(input))
                    {
                        this.controller.Buyers[input].BuyFood();
                    }
                }
            }

            totalAmountOfFoodPurchased += this.controller.Buyers.Sum(buyer => buyer.Value.Food);
            return totalAmountOfFoodPurchased.ToString();
        }

        private void ReadData()
        {
            var numberOfByuers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfByuers; i++)
            {
                var buyerData = Console.ReadLine().Split();

                if (buyerData.Length == 3)
                {
                    this.controller.RegisterRebel(buyerData);
                }
                else
                {
                    this.controller.RegisterCitizen(buyerData);
                }
            }
        }
    }
}

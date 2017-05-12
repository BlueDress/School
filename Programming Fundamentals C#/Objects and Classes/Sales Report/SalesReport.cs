using System;
using System.Collections.Generic;

namespace Sales_Report
{
    public class SalesReport
    {
        public static void Main()
        {
            var numberOfSales = int.Parse(Console.ReadLine());
            var listOfSales = new List<Sale>();
            var salesByTown = new SortedDictionary<string, double>();

            for (int i = 0; i < numberOfSales; i++)
            {
                var inputCommands = Console.ReadLine().Split();
                listOfSales.Add(new Sale
                {
                    Town = inputCommands[0],
                    Price = double.Parse(inputCommands[2]),
                    Quantity = double.Parse(inputCommands[3])
                });
            }
            for (int i = 0; i < listOfSales.Count; i++)
            {

                if (!salesByTown.ContainsKey(listOfSales[i].Town))
                {
                    salesByTown[listOfSales[i].Town] = 0;
                }
                salesByTown[listOfSales[i].Town] += listOfSales[i].Price * listOfSales[i].Quantity;
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key:f2} -> {town.Value:f2}");
            }
        }
    }
}

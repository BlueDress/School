using System;
using System.Collections.Generic;
using System.Linq;

namespace Andrey_and_billiard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var numberOfEntities = int.Parse(Console.ReadLine());
            var entities = new Dictionary<string, decimal>();

            for (int i = 0; i < numberOfEntities; i++)
            {
                var inputCommands = Console.ReadLine().Split('-').ToList();
                entities[inputCommands[0]] = decimal.Parse(inputCommands[1]);
            }

            var billInformation = new List<Client>();

            while (true)
            {
                var inputCommands = Console.ReadLine().Split('-', ',').ToList();

                if (inputCommands[0] == "end of clients")
                {
                    break;
                }
                else
                {
                    if (entities.ContainsKey(inputCommands[1]))
                    {
                        var newClient = new Client
                        {
                            Name = inputCommands[0],
                            Order = inputCommands[1],
                            Quantity = int.Parse(inputCommands[2]),
                            Bill = int.Parse(inputCommands[2]) * entities[inputCommands[1]]
                        };
                        billInformation.Add(newClient);
                    }
                }
            }

            var totalBill = 0m;

            foreach (var client in billInformation.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{client.Name}\n-- {client.Order} - {client.Quantity}\nBill: {client.Bill:f2}");
                totalBill += client.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}

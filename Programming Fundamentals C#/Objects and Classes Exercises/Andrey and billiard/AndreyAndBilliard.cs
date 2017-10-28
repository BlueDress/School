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

                var clientName = inputCommands[0];
                var entity = inputCommands[1];
                var quantity = int.Parse(inputCommands[2]);

                if (!entities.ContainsKey(entity))
                {
                    continue;
                }

                if (!billInformation.Any(x => x.Name.Equals(clientName)))
                {
                    var client = new Client(clientName);

                    if (!client.Orders.ContainsKey(entity))
                    {
                        client.Orders[entity] = 0;
                    }

                    client.Orders[entity] += quantity;

                    billInformation.Add(client);
                }
                else
                {
                    var currentClient = billInformation.First(x => x.Name.Equals(clientName));

                    if (!currentClient.Orders.ContainsKey(entity))
                    {
                        currentClient.Orders[entity] = 0;
                    }

                    currentClient.Orders[entity] += quantity;
                }
            }

            var totalBill = 0m;

            foreach (var client in billInformation.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{client.Name}");

                foreach (var item in client.Orders)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {client.GetBill(entities):f2}");

                totalBill += client.GetBill(entities);
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    public class AMinerTask
    {
        public static void Main()
        {
            var minersList = new Dictionary<string, int>();

            while (true)
            {
                var resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                else
                {
                    var quantity = int.Parse(Console.ReadLine());

                    if (!minersList.ContainsKey(resource))
                    {
                        minersList[resource] = 0;
                    }
                    minersList[resource] += quantity;
                }
            }
            foreach (KeyValuePair<string, int> item in minersList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

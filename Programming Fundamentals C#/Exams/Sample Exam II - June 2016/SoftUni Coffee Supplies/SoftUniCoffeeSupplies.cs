using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Coffee_Supplies
{
    public class SoftUniCoffeeSupplies
    {
        public static void Main()
        {
            var delimiters = Console.ReadLine().Split().ToArray();

            var firstDelimiter = delimiters[0];
            var secondDelimiter = delimiters[1];

            var coffeTypePeople = new SortedDictionary<string, List<string>>();
            var coffeTypeQuantity = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("end of info"))
                {
                    break;
                }
                else
                {
                    var indexFirstDelimiter = input.IndexOf(firstDelimiter);

                    if (indexFirstDelimiter != -1)
                    {
                        var nameCoffeType = input.Remove(indexFirstDelimiter, firstDelimiter.Length).Insert(indexFirstDelimiter, "&").Split('&').ToArray();
                        var name = nameCoffeType[0];
                        var coffeType = nameCoffeType[1];

                        if (!coffeTypePeople.ContainsKey(coffeType))
                        {
                            coffeTypePeople[coffeType] = new List<string>();
                        }

                        coffeTypePeople[coffeType].Add(name);

                        if (!coffeTypeQuantity.ContainsKey(coffeType))
                        {
                            coffeTypeQuantity[coffeType] = 0;
                        }
                    }
                    else
                    {
                        var indexSecondDelimiter = input.IndexOf(secondDelimiter);
                        var coffeQuantity = input.Remove(indexSecondDelimiter, secondDelimiter.Length).Insert(indexSecondDelimiter, "&").Split('&').ToArray();
                        var coffeType = coffeQuantity[0];
                        var quantity = int.Parse(coffeQuantity[1]);

                        if (!coffeTypeQuantity.ContainsKey(coffeType))
                        {
                            coffeTypeQuantity[coffeType] = 0;
                        }

                        coffeTypeQuantity[coffeType] += quantity;

                    }
                }
            }

            foreach (var type in coffeTypeQuantity)
            {
                if (type.Value <= 0)
                {
                    Console.WriteLine($"Out of {type.Key}");
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("end of week"))
                {
                    break;
                }
                else
                {
                    var nameQuantity = input.Split().ToArray();
                    var name = nameQuantity[0];
                    var quantity = int.Parse(nameQuantity[1]);

                    foreach (var type in coffeTypePeople)
                    {
                        if (type.Value.Contains(name))
                        {
                            coffeTypeQuantity[type.Key] -= quantity;
                            
                            if (coffeTypeQuantity[type.Key] <= 0)
                            {
                                Console.WriteLine($"Out of {type.Key}");
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Coffee Left:");

            foreach (var type in coffeTypeQuantity.OrderByDescending(x => x.Value))
            {
                if (type.Value > 0)
                {
                    Console.WriteLine($"{type.Key} {type.Value}");
                }
            }

            Console.WriteLine("For:");

            foreach (var type in coffeTypePeople)
            {
                if (coffeTypeQuantity[type.Key] > 0)
                {
                    foreach (var name in type.Value.OrderByDescending(x => x))
                    {
                        Console.WriteLine($"{name} {type.Key}");
                    }
                }
            }
        }
    }
}

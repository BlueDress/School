using System;
using System.Collections.Generic;
using System.Linq;

namespace Roli___The_Coder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            var idName = new Dictionary<int, string>();
            var nameParticipiants = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var request = Console.ReadLine();

                if (request.Equals("Time for Code"))
                {
                    break;
                }
                else
                {
                    var tokens = request.Split();
                    var name = tokens[1];

                    if (name.StartsWith("#"))
                    {
                        var id = int.Parse(tokens[0]);

                        if (!idName.ContainsKey(id))
                        {
                            idName[id] = name.Remove(0, 1);

                            for (int i = 2; i < tokens.Length; i++)
                            {
                                if (!nameParticipiants.ContainsKey(idName[id]))
                                {
                                    nameParticipiants[idName[id]] = new HashSet<string>();
                                }
                                nameParticipiants[idName[id]].Add(tokens[i]);
                            }
                        }
                        else
                        {
                            if (idName[id].Equals(name.Remove(0, 1)))
                            {
                                for (int i = 2; i < tokens.Length; i++)
                                {
                                    nameParticipiants[idName[id]].Add(tokens[i]);
                                }
                            }
                        }
                    }
                }
            }

            foreach (var item in idName)
            {
                if (!nameParticipiants.ContainsKey(item.Value))
                {
                    nameParticipiants[item.Value] = new HashSet<string>();
                }
            }

            foreach (var kvp in nameParticipiants.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Count}");

                foreach (var name in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}

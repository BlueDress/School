using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("search"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split('-');
                    var name = tokens[0];
                    var number = tokens[1];

                    phonebook[name] = number;
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("stop"))
                {
                    break;
                }
                else
                {
                    if (phonebook.ContainsKey(input))
                    {
                        Console.WriteLine($"{input} -> {phonebook[input]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input} does not exist.");
                    }
                }
            }
        }
    }
}

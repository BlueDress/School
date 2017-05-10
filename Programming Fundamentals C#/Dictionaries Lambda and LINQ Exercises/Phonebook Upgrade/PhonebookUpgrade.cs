using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            do
            {
                var inputCommands = Console.ReadLine().Split().ToList();

                if (inputCommands[0] == "END")
                {
                    break;
                }
                else
                {
                    switch (inputCommands[0])
                    {
                        case "A":
                            phonebook[inputCommands[1]] = inputCommands[2];
                            break;
                        case "S":
                            if (phonebook.ContainsKey(inputCommands[1]))
                            {
                                Console.WriteLine($"{inputCommands[1]} -> {phonebook[inputCommands[1]]}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {inputCommands[1]} does not exist.");
                            }
                            break;
                        case "ListAll":
                            foreach (KeyValuePair<string, string> item in phonebook)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                            break;
                    }
                }

            } while (true);
        }
    }
}

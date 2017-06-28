using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    public class SoftUniParty
    {
        public static void Main()
        {
            var guests = new SortedSet<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("PARTY"))
                {
                    break;
                }
                else
                {
                    guests.Add(input);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    if (guests.Contains(input))
                    {
                        guests.Remove(input);
                    }
                }
            }

            Console.WriteLine(guests.Count);
            
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

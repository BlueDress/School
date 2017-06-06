using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var demonBook = new List<Demon>();

            var damagePattern = @"[+-]?\d+\.?\d*";

            foreach (var demon in input)
            {
                var name = demon;
                var health = 0;

                foreach (var symbol in demon)
                {
                    if (char.IsLetter(symbol))
                    {
                        health += symbol;
                    }
                }

                var regex = new Regex(damagePattern);
                var damage = 0d;

                var matches = regex.Matches(demon);

                foreach (Match match in matches)
                {
                    damage += double.Parse(match.ToString());
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                var newDemon = new Demon
                {
                    Name = name,
                    Health = health,
                    Damage = damage
                };

                demonBook.Add(newDemon);
            }

            foreach (var demon in demonBook.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}

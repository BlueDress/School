using System;
using System.Collections.Generic;
using System.Linq;

namespace King_s_Gambit
{
    public class Startup
    {
        public static void Main()
        {
            var king = new King(Console.ReadLine());

            var soldiers = new List<Soldier>();
            soldiers.AddRange(Console.ReadLine().Split().Select(rg => new RoyalGuard(rg)));
            soldiers.AddRange(Console.ReadLine().Split().Select(f => new Footman(f)));
            soldiers.ForEach(soldier => king.UnderAttack += soldier.OnUnderAttack);

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                var commandArgs = input.Split();
                var command = commandArgs[0];

                if (command.Equals("Attack"))
                {
                    king.KingUnderAttack();
                }
                else
                {
                    var soldier = soldiers.Find(s => s.Name.Equals(commandArgs[1]));
                    soldiers.Remove(soldier);
                    king.UnderAttack -= soldier.OnUnderAttack;
                }
            }
        }
    }
}

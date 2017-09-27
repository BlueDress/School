using System;

namespace Neighbour_Wars
{
    public class Startup
    {
        public static void Main()
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());

            var peshosHealth = 100;
            var goshosHealth = 100;
            var round = 1;

            while (true)
            {
                if (round % 2 == 0)
                {
                    peshosHealth -= goshosDamage;

                    if (peshosHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                else
                {
                    goshosHealth -= peshosDamage;

                    if (goshosHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }

                if (round % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }

                round++;
            }
        }
    }
}

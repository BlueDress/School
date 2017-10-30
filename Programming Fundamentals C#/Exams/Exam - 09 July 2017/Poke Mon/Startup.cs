using System;

namespace Poke_Mon
{
    public class Startup
    {
        public static void Main()
        {
            var pokePower = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());

            var originalPokePower = pokePower;
            var pokedTargets = 0;
            
            while (true)
            {
                if (pokePower * 2 == originalPokePower && pokePower >= exhaustionFactor && exhaustionFactor > 0)
                {
                    pokePower = pokePower / exhaustionFactor;
                }

                if (pokePower < distance)
                {
                    break;
                }

                pokePower = pokePower - distance;
                pokedTargets++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}

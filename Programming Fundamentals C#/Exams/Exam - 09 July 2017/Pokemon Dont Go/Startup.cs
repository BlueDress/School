using System;
using System.Linq;

namespace Pokemon_Dont_Go
{
    public class Startup
    {
        public static void Main()
        {
            var pokemons = Console.ReadLine().Split().Select(long.Parse).ToList();

            var result = 0L;

            while (true)
            {
                var index = int.Parse(Console.ReadLine());
                var removedElementValue = 0L;

                if (index < 0)
                {
                    removedElementValue = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (index >= pokemons.Count)
                {
                    removedElementValue = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    removedElementValue = pokemons[index];
                    pokemons.RemoveAt(index);

                    if (pokemons.Count == 0)
                    {
                        result += removedElementValue;
                        break;
                    }
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removedElementValue)
                    {
                        pokemons[i] += removedElementValue;
                    }
                    else
                    {
                        pokemons[i] -= removedElementValue;
                    }
                }

                result += removedElementValue;
            }

            Console.WriteLine(result);
        }
    }
}

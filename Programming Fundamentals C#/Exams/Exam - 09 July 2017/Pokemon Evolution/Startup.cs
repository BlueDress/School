using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Evolution
{
    public class Startup
    {
        public static void Main()
        {
            var pokemons = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("wubbalubbadubdub"))
                {
                    break;
                }

                var args = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var pokemonName = args[0];

                if (args.Length == 1)
                {
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var pokemon in pokemons[pokemonName])
                        {
                            Console.WriteLine($"{pokemon.EvolutionType} <-> {pokemon.EvolutionIndex}");
                        }
                    }
                }
                else
                {
                    var evolutionType = args[1];
                    var evolutionIndex = int.Parse(args[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Pokemon>();
                    }

                    pokemons[pokemonName].Add(new Pokemon(pokemonName, evolutionType, evolutionIndex));
                }
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evolution in pokemon.Value.OrderByDescending(p => p.EvolutionIndex))
                {
                    Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                }
            }
        }
    }
}

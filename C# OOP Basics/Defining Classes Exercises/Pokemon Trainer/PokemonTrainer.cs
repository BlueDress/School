using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            CatchingPokemons(trainers);
            PlayTheTournament(trainers);
            PrintResults(trainers);
        }

        private static void PrintResults(List<Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(trainer => trainer.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void PlayTheTournament(List<Trainer> trainers)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var element = input;

                    foreach (var trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(pokemon => pokemon.Element.Equals(element)))
                        {
                            trainer.Badges += 1;
                        }
                        else
                        {
                            trainer.Pokemons.ForEach(pokemon => pokemon.Health -= 10);
                            trainer.Pokemons = trainer.Pokemons.Where(pokemon => pokemon.Health > 0).ToList();
                        }
                    }
                }
            }
        }

        private static void CatchingPokemons(List<Trainer> trainers)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Tournament"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var trainerName = tokens[0];
                    var pokemonName = tokens[1];
                    var pokemonElement = tokens[2];
                    var pokemonHealth = double.Parse(tokens[3]);

                    var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);


                    if (!trainers.Any(trainer => trainer.Name.Equals(trainerName)))
                    {
                        var trainer = new Trainer();
                        trainer.Name = trainerName;
                        trainer.Pokemons.Add(pokemon);
                        trainers.Add(trainer);
                    }
                    else
                    {
                        var trainer = trainers.Find(tr => tr.Name.Equals(trainerName));
                        trainer.Pokemons.Add(pokemon);
                    }
                }
            }
        }
    }
}

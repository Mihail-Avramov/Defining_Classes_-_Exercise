using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = inputArguments[0];
                string pokemonName = inputArguments[1];
                string pokemonElement = inputArguments[2];
                int pokemonHealth = int.Parse(inputArguments[3]);

                if (trainers.Any(t => t.Name == trainerName))
                {
                    Trainer currentTrainer = trainers.First(t => t.Name == trainerName);
                    currentTrainer.AddPokemon(pokemonName, pokemonElement, pokemonHealth);
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName, pokemonName, pokemonElement, pokemonHealth);
                    trainers.Add(newTrainer);
                }
            }

            input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.CheckPokemonsElement(input);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.BadgesCounter))
            {
                Console.WriteLine(trainer.PrintTrainer());
            }
        }
    }
}
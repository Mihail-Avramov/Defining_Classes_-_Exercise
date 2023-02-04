using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
		private string name;
		private int badgesCounter;
		private List<Pokemon> pokemons = new List<Pokemon>();

		public Trainer(string trainerName, string pokemonName, string pokemonElement, int pokemonHealth)
        {
			this.name = trainerName;
            this.badgesCounter = 0;
            AddPokemon(pokemonName,pokemonElement,pokemonHealth);
        }

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
		}

		public int BadgesCounter
        {
			get { return badgesCounter; }
		}

		public string Name
		{
			get { return name; }
		}

        public void AddPokemon(string pokemonName, string pokemonElement, int pokemonHealth)
        {
            this.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
        }

        public void CheckPokemonsElement(string pokemonElement)
        {
            if (this.pokemons.Any(p => p.Element == pokemonElement))
            {
                this.badgesCounter++;
            }
            else
            {
                foreach (var pokemon in this.pokemons)
                {
                    pokemon.Health -= 10;
                }
                this.pokemons.RemoveAll(p => p.Health <= 0);
            }
        }


        public string PrintTrainer()
        {
            return $"{this.Name} {this.BadgesCounter} {this.Pokemons.Count}";
        }
    }
}

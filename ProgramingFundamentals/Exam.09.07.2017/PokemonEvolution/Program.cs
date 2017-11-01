using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Pokemon
    {
        public string Evoltuion { get; set; }
        public int Index { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { " ", "-", ">","\\t"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, List<Pokemon>> pokemons = new Dictionary<string, List<Pokemon>>();

            while (input[0] != "wubbalubbadubdub")
            {
                
                if (input.Length == 1)
                {
                    string pokeName = input[0].Trim();
                    if (pokemons.ContainsKey(pokeName))
                    {
                        Console.WriteLine($"# {pokeName}");
                        foreach (var element in pokemons[pokeName])
                        {
                            Console.WriteLine($"{element.Evoltuion} <-> {element.Index}");
                        }
                    }
                }
                else
                {
                    Pokemon currentPokemon = new Pokemon();
                    string pokemonName = input[0];
                    currentPokemon.Evoltuion = input[1];
                    currentPokemon.Index=int.Parse(input[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {

                        pokemons.Add(pokemonName, new List<Pokemon>());

                    }
                    
                        pokemons[pokemonName].Add(currentPokemon);
                    
                }

                input = Console.ReadLine()
                    .Split(new string[] { " ", "-", ">" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evolution in pokemon.Value.OrderByDescending(x=>x.Index))
                {
                    Console.WriteLine($"{evolution.Evoltuion} <-> {evolution.Index}");
                }
            }
        }
    }
}

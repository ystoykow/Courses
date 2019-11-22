namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,Trainer> trainers = new Dictionary<string, Trainer>();
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "Tournament")
            {
                string trainerName = commands[0];
                string pokemonName = commands[1];
                string pokemonElement = commands[2];
                int pokemonHealth = int.Parse(commands[3]);
                Pokemon currentPokemon = new Pokemon()
                {
                    Name = pokemonName,
                    Element = pokemonElement,
                    Health = pokemonHealth
                };

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName,new Trainer());
                }

                trainers[trainerName].Pokemons.Add(currentPokemon);
                commands = Console.ReadLine().Split();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    bool result = false;
                    foreach (var pokemon in trainer.Value.Pokemons)
                    {
                        if (pokemon.Element == command)
                        {
                            result = true;
                            break;
                        }
                    }

                    if (result)
                    {
                        trainer.Value.badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Value.Pokemons = trainer.Value.Pokemons.Where(p => p.Health > 0).ToList();
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t=>t.Value.badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}

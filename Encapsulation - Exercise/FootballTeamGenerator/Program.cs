namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            HashSet<Team> teams = new HashSet<Team>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    string[] tokens = input.Split(";",StringSplitOptions.RemoveEmptyEntries);
                    string command = tokens[0];
                    string name = tokens[1];
                    if (command == "Team")
                    {
                        Team team = new Team(name);
                        teams.Add(team);
                    }
                    else if (command == "Add")
                    {
                        string playerName = tokens[2];
                        int endurance = int.Parse(tokens[3]);
                        int sprint = int.Parse(tokens[4]);
                        int dribble = int.Parse(tokens[5]);
                        int passing = int.Parse(tokens[6]);
                        int shooting = int.Parse(tokens[7]);
                        Team current = teams.FirstOrDefault(t => t.Name == name);
                        if (current == null)
                        {
                            throw new ArgumentException($"Team {name} does not exist.");
                        }

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        current.AddPlayer(player);
                    }
                    else if (command == "Remove")
                    {
                        string playerName = tokens[2];
                        Team current = teams.FirstOrDefault(t => t.Name == name);
                        if (current == null)
                        {
                            throw new ArgumentException($"Team {name} does not exist.");
                        }

                        current.RemovePlayer(playerName);
                    }
                    else if (command == "Rating")
                    {
                        Team current = teams.FirstOrDefault(t => t.Name == name);
                        if (current == null)
                        {
                            throw new ArgumentException($"Team {name} does not exist.");
                        }

                        Console.WriteLine($"{name} - {current.Rating}");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}

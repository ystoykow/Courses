namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheVlogger
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string first = tokens[0];
                string command = tokens[1];
                string second = tokens[2];
                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(first))
                    {
                        vloggers.Add(first, new Dictionary<string, HashSet<string>>());
                        vloggers[first].Add("followers", new HashSet<string>());
                        vloggers[first].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    if (vloggers.ContainsKey(first) && vloggers.ContainsKey(second) && first != second)
                    {
                        vloggers[second]["followers"].Add(first);
                        vloggers[first]["following"].Add(second);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int i = 1;
            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{i}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                if (i == 1)
                {
                    foreach (var followers in vlogger.Value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }

                i++;
            }
        }
    }
}

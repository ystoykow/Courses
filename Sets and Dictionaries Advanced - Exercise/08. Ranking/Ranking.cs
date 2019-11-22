namespace _08._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ranking
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                contests.Add(contest, password);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new Dictionary<string, int>());
                    }

                    if (!users[username].ContainsKey(contest))
                    {
                        users[username].Add(contest, points);
                    }

                    if (users[username][contest] < points)
                    {
                        users[username][contest] = points;
                    }
                }


                input = Console.ReadLine();
            }

            int mostPoints = 0;
            string bestUser = string.Empty;
            foreach (var user in users)
            {
                int currentBest = 0;
                foreach (var contest in user.Value)
                {
                    currentBest += contest.Value;
                    if (mostPoints < currentBest)
                    {
                        bestUser = user.Key;
                        mostPoints = currentBest;
                    }
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {mostPoints} points.");
            Console.WriteLine($"Ranking:");
            foreach (var user in users.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var contest in user.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}

namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            int recordsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < recordsCount; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentCloth = clothes[j];
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }

                    if (!wardrobe[color].ContainsKey(currentCloth))
                    {
                        wardrobe[color].Add(currentCloth, 0);
                    }

                    wardrobe[color][currentCloth]++;
                }
            }

            string[] searchedCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var innerKvp in kvp.Value)
                {
                    if (searchedCloth[0]==kvp.Key && searchedCloth[1]== innerKvp.Key)
                    {
                        Console.WriteLine($"* {innerKvp.Key} - {innerKvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {innerKvp.Key} - {innerKvp.Value}");
                    }
                }
            }
        }
    }
}

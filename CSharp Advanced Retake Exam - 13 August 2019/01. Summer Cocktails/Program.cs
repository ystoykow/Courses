namespace _01._Summer_Cocktails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Dictionary<int, string> cocktails = new Dictionary<int, string>();
            cocktails.Add(150, "Mimosa");
            cocktails.Add(250, "Daiquiri");
            cocktails.Add(300, "Sunshine");
            cocktails.Add(400, "Mojito");
            Dictionary<string, int> results = new Dictionary<string, int>();
            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int currentIngredient = ingredients.Dequeue();
                int currentFreshness = freshness.Pop();
                int total = currentFreshness * currentIngredient;

                if (cocktails.ContainsKey(total))
                {
                    string currentCoctailName = cocktails[total];
                    if (!results.ContainsKey(currentCoctailName))
                    {
                        results.Add(currentCoctailName, 0);
                    }

                    results[currentCoctailName]++;
                }
                else
                {
                    ingredients.Enqueue(currentIngredient + 5);
                }
            }

            if (results.Count == 4)
            {
                Console.WriteLine($"It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine($"What a pity! You didn't manage to prepare all cocktails.");
            }

            if (ingredients.Count > 0)
            {
                int sum = ingredients.Sum();
                Console.WriteLine($"Ingredients left: {sum}");
            }

            foreach (var cocktail in results.OrderBy(c=>c.Key))
            {
                Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
            }
        }
    }
}

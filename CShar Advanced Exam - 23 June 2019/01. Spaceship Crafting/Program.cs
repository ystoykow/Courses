namespace _01._Spaceship_Crafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var items = new Dictionary<int, string>();
            items.Add(25, "Glass");
            items.Add(50, "Aluminium");
            items.Add(75, "Lithium");
            items.Add(100, "Carbon fiber");

            Queue<int> chemicalsLiquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> psychicalItems = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string,int> craftedItems = new Dictionary<string, int>();
            craftedItems.Add("Glass",0);
            craftedItems.Add("Aluminium", 0);
            craftedItems.Add("Lithium", 0);
            craftedItems.Add("Carbon fiber", 0);

            while (chemicalsLiquids.Count > 0 && psychicalItems.Count > 0)
            {
                int currentChemical = chemicalsLiquids.Dequeue();
                int currentPsychical = psychicalItems.Pop();
                int result = currentPsychical + currentChemical;
                if (items.ContainsKey(result))
                {
                    craftedItems[items[result]]++;
                }
                else
                {
                    psychicalItems.Push(currentPsychical+3);
                }
            }

            bool isCrafted = true;
            foreach (var item in craftedItems)
            {
                if (item.Value == 0)
                {
                    isCrafted = false;
                    break;
                }
            }

            if (isCrafted)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            string liquidsLeft = "Liquids left: ";
            if (chemicalsLiquids.Count > 0)
            {
                liquidsLeft += $"{string.Join(", ", chemicalsLiquids)}";
            }
            else
            {
                liquidsLeft += "none";
            }

            Console.WriteLine(liquidsLeft);
            string itemsLeft = "Physical items left: ";
            if (psychicalItems.Count > 0)
            {
                itemsLeft += $"{string.Join(", ", psychicalItems)}";
            }
            else
            {
                itemsLeft += "none";
            }

            Console.WriteLine(itemsLeft);
            foreach (var currentItem in craftedItems.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{currentItem.Key}: {currentItem.Value}");
            }
        }
    }
}

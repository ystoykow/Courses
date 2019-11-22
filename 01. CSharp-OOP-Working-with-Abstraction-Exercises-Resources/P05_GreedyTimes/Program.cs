namespace P05_GreedyTimes
{
    using System;

    public class Potato
    {
        public static void Main()
        {
            long capacity = long.Parse(Console.ReadLine());
            string[] items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Bag bag = new Bag(capacity);
            for (int i = 0; i < items.Length; i += 2)
            {
                string type = items[i];
                long amount = long.Parse(items[i + 1]);
            
                bag.Add(type, amount);

            }

            Console.WriteLine(bag.GetInfo());
        }
    }
}
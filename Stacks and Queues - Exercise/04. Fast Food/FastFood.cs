namespace _04._Fast_Food
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FastFood
    {
        public static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Console.WriteLine(orders.Max());
            while (orders.Count != 0)
            {
                int currentOrder = orders.Peek();
                if (currentOrder > quantityOfFood)
                {
                    break;
                }
                else
                {
                    quantityOfFood -= orders.Dequeue();
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
        }
    }
}

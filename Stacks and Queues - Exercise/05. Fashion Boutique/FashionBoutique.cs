namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FashionBoutique
    {
        public static void Main()
        {
            Stack<int> totalCloths = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackCap = int.Parse(Console.ReadLine());
            int countRacks = 1;
            int sum = 0;
            while (totalCloths.Count != 0)
            {
                int currentCloth = totalCloths.Pop();
                if (sum + currentCloth <= rackCap)
                {
                    sum += currentCloth;
                }
                else
                {
                    sum = 0;
                    countRacks++;
                    sum += currentCloth;
                }
            }

            Console.WriteLine(countRacks);
        }
    }
}

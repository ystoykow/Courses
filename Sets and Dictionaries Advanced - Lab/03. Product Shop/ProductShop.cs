namespace _03._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductShop
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> markets = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = tokens[0];
                string productName = tokens[1];
                double productPrice = double.Parse(tokens[2]);
                if (!markets.ContainsKey(shopName))
                {
                    markets.Add(shopName, new Dictionary<string, double>());
                }

                markets[shopName].Add(productName, productPrice);

                input = Console.ReadLine();
            }

            foreach (var kvp in markets.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
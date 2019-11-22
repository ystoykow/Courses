using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        try
        {
            var selectedCoins = ChooseCoins(availableCoins, targetSum);
            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var chosenCoins = new Dictionary<int, int>();
        coins = coins.OrderBy(x => x).ToList();
        for (int i = coins.Count - 1; i >= 0; i--)
        {
            int currentCoin = coins[i];
            if (targetSum - currentCoin >= 0)
            {
                int totalCoins = targetSum / currentCoin;
                targetSum -= totalCoins * currentCoin;

                if (!chosenCoins.ContainsKey(currentCoin))
                {
                    chosenCoins.Add(currentCoin, totalCoins);
                }
            }

            if (targetSum == 0)
            {
                break;
            }
        }

        if (targetSum != 0)
        {
            throw new InvalidOperationException();
        }

        return chosenCoins;
    }
}
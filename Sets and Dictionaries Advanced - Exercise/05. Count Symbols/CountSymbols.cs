namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbols
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            Dictionary<char,int> symbolsCounter = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (!symbolsCounter.ContainsKey(currentChar))
                {
                    symbolsCounter.Add(currentChar,0);
                }

                symbolsCounter[currentChar]++;
            }

            foreach (var symbol in symbolsCounter.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}

namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class CountUppercaseWords
    {
        public static void Main()
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Where(x => char.IsUpper(x[0]))
                  .ToList()
                  .ForEach(x=>Console.WriteLine(x));
        }
    }
}

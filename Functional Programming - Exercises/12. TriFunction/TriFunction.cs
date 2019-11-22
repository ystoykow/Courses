namespace _12._TriFunction
{
    using System;
    using System.Linq;

    public class TriFunction
    {
        public static void Main()
        {
            int max = int.Parse(Console.ReadLine());
            string[] allNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, int, bool> largerNameFunc = (x, y) => x.Sum(ch => ch) >= y;
            Func<string[], Func<string, int, bool>, string> firstValidNameFunc = (names, func) =>
                names.FirstOrDefault(name => func(name, max));
            string result = firstValidNameFunc(allNames, largerNameFunc);
            Console.WriteLine(result);
        }
    }
}

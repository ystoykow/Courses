namespace _07._Predicate_For_Names
{
    using System;
    using System.Linq;

    public class PredicateForNames
    {
        public static void Main()
        {
            int maxLength = int.Parse(Console.ReadLine());
            Func<string,bool> filter = x => x.Length <= maxLength;
            Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x=>filter(x)).ToList().ForEach(Console.WriteLine);
        }
    }
}

namespace _01._Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ActionPrint
    {
        public static void Main()
        {
            Action<string> print = Console.WriteLine;
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            names.ForEach(print);
        }
    }
}

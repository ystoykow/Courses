﻿namespace _02._Knights_of_Honor
{
    using System;
    using System.Linq;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            Action<string> MakeItSirr = n => Console.WriteLine($"Sir {n}");
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(MakeItSirr);
        }
    }
}
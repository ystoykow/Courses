namespace _10._Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string criteria = commands[1];
                string parameters = commands[2];
                Func<string, string, bool> predicate = GetFunc(criteria);
                if (command == "Double")
                {
                    List<string> toAdd = people.Where(p => predicate(p, parameters)).ToList();
                    foreach (var name in toAdd)
                    {
                        int indexOfname = people.IndexOf(name);
                        people.Insert(indexOfname + 1, name);
                    }
                }
                else
                {
                    people = people.Where(p => !predicate(p, parameters)).ToList();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(people.Count > 0 ? $"{string.Join(", ", people)} are going to the party!" : $"Nobody is going to the party!");
        }

        public static Func<string, string, bool> GetFunc(string criteria)
        {
            if (criteria == "StartsWith")
            {
                return (p, x) => p.StartsWith(x);
            }
            else if (criteria == "Length")
            {
                return (p, x) => p.Length == int.Parse(x);
            }
            else if (criteria == "EndsWith")
            {
                return (p, x) => p.EndsWith(x);
            }

            return null;
        }
    }
}

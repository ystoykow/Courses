using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split(" ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                var currentPerson = new Person(name,age,town);
                people.Add(currentPerson);

                input = Console.ReadLine();
            }

            int indexOfPersonToCompare = int.Parse(Console.ReadLine()) -1;
            Person personToCompare = people[indexOfPersonToCompare];
            people.RemoveAt(indexOfPersonToCompare);

            int equalPersons = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (personToCompare.CompareTo(people[i]) == 0)
                {
                    equalPersons++;
                }
            }

            if (equalPersons == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{++equalPersons} {(people.Count+1)-equalPersons} {people.Count+1}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedSetPerson = new SortedSet<Person>();
            HashSet<Person> hashSetPerson = new HashSet<Person>();
            for (int i = 0; i < count; i++)
            {
                string[] current = Console.ReadLine().Split();
                string name = current[0];
                int age = int.Parse(current[1]);
                Person currentPerson = new Person
                {
                    Name = name,
                    Age = age
                };

                sortedSetPerson.Add(currentPerson);
                hashSetPerson.Add(currentPerson);
            }

            Console.WriteLine(sortedSetPerson.Count);
            Console.WriteLine(hashSetPerson.Count);
        }
    }
}

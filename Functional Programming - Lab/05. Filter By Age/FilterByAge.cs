namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByAge
    {
        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

        public static void Main()
        {
            List<Person> people = new List<Person>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                Person currentPerson = new Person();
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                currentPerson.Name = input[0];
                currentPerson.Age = int.Parse(input[1]);
                people.Add(currentPerson);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> filterPredicate;
            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            Func<Person, string> selectFunc;
            if (format == "age")
            {
                selectFunc = p => $"{p.Age}";
            }
            else if (format == "name")
            {
                selectFunc = p => $"{p.Name}";
            }
            else if (format == "age name")
            {
                selectFunc = p => $"{p.Age} - {p.Name}";
            }
            else
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }

            people.Where(filterPredicate)
                .Select(selectFunc)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}

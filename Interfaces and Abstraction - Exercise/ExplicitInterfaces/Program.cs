namespace ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            List<Citizen> people = new List<Citizen>();
            while (command != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);
                Citizen current = new Citizen(name, age, country);
                people.Add(current);

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                IPerson personAsIPerson = person;
                IResident personAsIResident = person;
                Console.WriteLine(personAsIPerson.GetName());
                Console.WriteLine(personAsIResident.GetName());
            }
        }
    }
}

namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string id = tokens[1];
                string firstName = tokens[2];
                string lastName = tokens[3];

                if (tokens[0] == "Private")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    Private current = new Private(firstName, lastName, id, salary);
                    soldiers.Add(current);
                }
                else if (tokens[0] == "Commando")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    string corps = tokens[5];
                    Commando current = new Commando(firstName, lastName, id, salary, corps, tokens.Skip(6).ToArray());
                    if (current.Corps != null)
                    {
                        soldiers.Add(current);
                    }
                }
                else if (tokens[0] == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    List<Private> privates = new List<Private>();
                    for (int i = 5; i < tokens.Length; i++)
                    {
                        Private soldier = (Private)soldiers.First(s => s.Id == tokens[i]);
                        privates.Add(soldier);
                    }

                    LieutenantGeneral current = new LieutenantGeneral(firstName, lastName, id, salary, privates);
                    soldiers.Add(current);
                }
                else if (tokens[0] == "Engineer")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    string corps = tokens[5];
                    Engineer current = new Engineer(firstName, lastName, id, salary, corps, tokens.Skip(6).ToArray());
                    if (current.Corps != null)
                    {
                        soldiers.Add(current);
                    }
                }
                else if (tokens[0] == "Spy")
                {
                    int codeNumber = int.Parse(tokens[4]);
                    Spy current = new Spy(firstName, lastName, id, codeNumber);
                    soldiers.Add(current);
                }

                command = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}

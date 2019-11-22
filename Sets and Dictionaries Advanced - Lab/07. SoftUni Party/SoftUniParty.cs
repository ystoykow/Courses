namespace _07._SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (input.Length == 8)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vip.Add(input);
                    }
                    else
                    {
                        regular.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                string currentGuest = input;
                if (char.IsDigit(currentGuest[0]))
                {
                    if (vip.Contains(currentGuest))
                    {
                        vip.Remove(currentGuest);
                    }
                }
                else
                {
                    if (regular.Contains(currentGuest))
                    {
                        regular.Remove(currentGuest);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{vip.Count + regular.Count}");
            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);                
            }
        }
    }
}

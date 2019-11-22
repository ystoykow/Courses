namespace _01._Trojan_Invasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int waves = int.Parse(Console.ReadLine());
            List<int> plates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            bool isAttackWin = false;
            for (int i = 1; i <= waves; i++)
            {
                Stack<int> warriors = new Stack<int>(Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray());

                if (i % 3 == 0)
                {
                    int additionalPlate = int.Parse(Console.ReadLine());
                    plates.Add(additionalPlate);
                }

                while (warriors.Count > 0 && plates.Count > 0)
                {
                    int warriorPower = warriors.Pop();
                    if (warriorPower > plates[0])
                    {
                        warriorPower -= plates[0];
                        plates.RemoveAt(0);
                        warriors.Push(warriorPower);
                    }
                    else if (plates[0] > warriorPower)
                    {
                        plates[0] -= warriorPower;
                    }
                    else
                    {
                        plates.RemoveAt(0);
                    }
                }

                if (plates.Count == 0)
                {
                    isAttackWin = true;
                    Console.WriteLine($"The Trojans successfully destroyed the Spartan defense.");
                    Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
                    break;
                }
            }

            if (!isAttackWin)
            {
                Console.WriteLine($"The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}

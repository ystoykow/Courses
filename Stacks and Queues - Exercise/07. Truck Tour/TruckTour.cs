namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        public static void Main()
        {
            int petrolStances = int.Parse(Console.ReadLine());
            Queue<string> stancesInfo = new Queue<string>();
            Queue<string> backup = new Queue<string>();
            for (int i = 0; i < petrolStances; i++)
            {
                stancesInfo.Enqueue(Console.ReadLine());
            }

            int index = -1;
            int petrol = 0;
            int bestIndex = int.MaxValue;

            while (stancesInfo.Count!=0)
            {
                string currentStanceInfo = stancesInfo.Dequeue();
                backup.Enqueue(currentStanceInfo);
                int[] stanceInfo = currentStanceInfo.Split().Select(int.Parse).ToArray();
                int currentDistance = stanceInfo[1];
                int currentPetrol = stanceInfo[0];
                index++;
                if (petrol + currentPetrol >= currentDistance)
                {
                    petrol += currentPetrol;
                    petrol -= currentDistance;
                    if (index < bestIndex)
                    {
                        bestIndex = index;
                    }
                }
                else
                {
                    while (backup.Count != 0)
                    {
                        stancesInfo.Enqueue(backup.Dequeue());
                    }
                    petrol = 0;
                    bestIndex = int.MaxValue;
                }
            }

            Console.WriteLine(bestIndex);
        }
    }
}

namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyRevolver
    {
        public static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            int counter = 0;
            int countBullets = 0;

            while (bullets.Count != 0 && locks.Count!=0)
            {
                int currentBullet = bullets.Pop();
                int curentLock = locks.Peek();
                countBullets++;
                counter++;
                if (currentBullet <= curentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (counter == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence-bulletPrice*countBullets}");
            }
        }
    }
}

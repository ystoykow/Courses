namespace _6._Hot_Potato
{
    using System;
    using System.Collections.Generic;

    public class HotPotato
    {
        public static void Main()
        {
            string[] childNames = Console.ReadLine().Split();
            int counter = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(childNames);
            
            while (children.Count > 1)
            {
                string currentChild = String.Empty;
                for (int i = 0; i < counter; i++)
                {
                    currentChild = children.Dequeue();
                    if (i + 1 != counter)
                    {
                        children.Enqueue(currentChild);
                    }
                }

                Console.WriteLine($"Removed {currentChild}");
            }

            Console.WriteLine($"Last is {children.Peek()}");
        }
    }
}

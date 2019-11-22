namespace _01._Club_Party
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> input = new Stack<string>(Console.ReadLine().Split(" "));
            int sum = 0;
            Queue<string> halls = new Queue<string>();
            Queue<int> reservation = new Queue<int>();
            while (input.Count != 0)
            {
                string current = input.Pop();
                if (char.IsLetter(current[0]))
                {
                    halls.Enqueue(current);
                    continue;
                }

                if (halls.Count > 0)
                {
                    int currentReservation = int.Parse(current);
                    if (sum + currentReservation <= capacity)
                    {
                        sum += currentReservation;
                        reservation.Enqueue(currentReservation);
                    }
                    else
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", reservation)}");
                        reservation.Clear();
                        sum = 0;
                        if (halls.Count > 0)
                        {
                            sum += currentReservation;
                            reservation.Enqueue(currentReservation);
                        }
                    }
                }
            }
        }
    }
}

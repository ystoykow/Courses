namespace _7._Lego_Blocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] firstJagged = new int[rows][];
            int[][] secondJagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                firstJagged[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
            }

            for (int i = 0; i < rows; i++)
            {
                secondJagged[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .Reverse().ToArray();
            }

            int maxIndex = firstJagged[0].Length + secondJagged[0].Length;
            bool isEqual = CheckEquality(firstJagged, secondJagged, maxIndex, rows);

            if (isEqual)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstJagged[i])}, {string.Join(", ", secondJagged[i])}]");
                }
            }
            else
            {
                int countCells = 0;
                for (int i = 0; i < rows; i++)
                {
                    countCells += firstJagged[i].Length;
                    countCells += secondJagged[i].Length;
                }

                Console.WriteLine($"The total number of cells is: {countCells}");
            }
        }

        public static bool CheckEquality(int[][] firstJagged, int[][] secondJagged, int maxIndex, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                if (firstJagged[i].Length + secondJagged[i].Length != maxIndex)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

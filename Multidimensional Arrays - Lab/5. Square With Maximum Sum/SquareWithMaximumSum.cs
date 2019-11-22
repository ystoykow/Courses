namespace _5._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int biggestSum = 0;
            int[] bestRow = new int[2];
            int[] bestCol = new int[2];

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] > biggestSum)
                    {
                        biggestSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        bestRow[0] = matrix[row, col];
                        bestRow[1] = matrix[row, col + 1];
                        bestCol[0] = matrix[row + 1, col];
                        bestCol[1] = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{bestRow[0]} {bestRow[1]}");
            Console.WriteLine($"{bestCol[0]} {bestCol[1]}");
            Console.WriteLine(biggestSum);
        }
    }
}

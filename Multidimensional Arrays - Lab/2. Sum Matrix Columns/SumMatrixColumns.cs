namespace _2._Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    public class SumMatrixColumns
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int currentColSum = 0;
                for (int row = 0; row < rows; row++)
                {
                    currentColSum += matrix[row, col];
                }

                Console.WriteLine(currentColSum);
            }
        }
    }
}

namespace _4._Maximal_Sum
{
    using System;
    using System.Linq;
    
    public class MaximalSum
    {
        public static void Main()
        {
            int[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int rows = matrixSizes[0];
            int cols = matrixSizes[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = 0;
            int[,] bestSubMatrix = new int[3, 3];
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                     matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        SetBestSubMatrix(bestSubMatrix, matrix, row, col);
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            PrintBestSubMatrix(bestSubMatrix);
        }

        public static void PrintBestSubMatrix(int[,] bestSubMatrix)
        {
            for (int i = 0; i < bestSubMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bestSubMatrix.GetLength(1); j++)
                {
                    if (j < bestSubMatrix.GetLength(1))
                    {
                        Console.Write(bestSubMatrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(bestSubMatrix[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }

        public static void SetBestSubMatrix(int[,] bestSubMatrix, int[,] matrix, int row, int col)
        {
            for (int i = 0; i < bestSubMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bestSubMatrix.GetLength(1); j++)
                {
                    bestSubMatrix[i, j] = matrix[row + i, col + j];
                }
            }
        }
    }
}

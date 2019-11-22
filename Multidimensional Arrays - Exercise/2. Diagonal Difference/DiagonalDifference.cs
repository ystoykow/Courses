namespace _2._Diagonal_Difference
{
    using System.Linq;
    using System;

    public class DiagonalDifference
    {
        public static void Main()
        {
            int matrixSides = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSides, matrixSides];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < matrixSides; row++)
            {
                int[] currentNumbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSides; col++)
                {
                    matrix[row, col] = currentNumbers[col];
                }
            }

            for (int row = 0; row < matrixSides; row++)
            {
                primaryDiagonal += matrix[row, row];
                secondaryDiagonal += matrix[row, matrixSides-1 - row];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }
    }
}

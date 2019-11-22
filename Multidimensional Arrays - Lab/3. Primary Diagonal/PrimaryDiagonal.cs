namespace _3._Primary_Diagonal
{
    using System;
    using System.Linq;

    public class PrimaryDiagonal
    {
        public static void Main()
        {
            int squareMatrixDimensions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareMatrixDimensions, squareMatrixDimensions];

            int primalDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (row == col)
                    {
                        primalDiagonalSum +=matrix[row, col];
                    }
                }
            }

            Console.WriteLine(primalDiagonalSum);
        }
    }
}

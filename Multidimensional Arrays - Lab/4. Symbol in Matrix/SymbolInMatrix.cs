namespace _4._Symbol_in_Matrix
{
    using System;

    public class SymbolInMatrix
    {
        public static void Main()
        {
            int squareMatrixDimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[squareMatrixDimensions, squareMatrixDimensions];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            char charToSearch = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (charToSearch == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{charToSearch} does not occur in the matrix");
        }
    }
}

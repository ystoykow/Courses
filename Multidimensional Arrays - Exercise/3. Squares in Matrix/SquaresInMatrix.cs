namespace _3._Squares_in_Matrix
{
    using System;
    using System.Linq;

    public class SquaresInMatrix
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int counter = 0;

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] currentChars = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentChars[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row + 1, col] == matrix[row + 1, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col + 1]
                    )
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

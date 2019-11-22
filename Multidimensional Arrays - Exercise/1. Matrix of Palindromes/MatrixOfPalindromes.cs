namespace _1._Matrix_of_Palindromes
{
    using System;
    using System.Linq;

    public class MatrixOfPalindromes
    {
       public static void Main()
        {
            int[] rowAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            string[,] matrix = new string[rows, cols];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] += alphabet[row];
                    matrix[row, col] += alphabet[col + row];
                    matrix[row, col] += alphabet[row];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}


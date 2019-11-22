namespace _9._Crossfire
{
    using System;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];
            FillMatrix(matrix, cols);
            string input = Console.ReadLine();
            while (input != "Nuke it from orbit")
            {
                int[] tokens = input.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int impactRow = tokens[0];
                int impactCol = tokens[1];
                int impactRange = tokens[2];

                for (int row = impactRow - impactRange; row <= impactRow + impactRange; row++)
                {
                    if (row >= 0 && row < matrix.Length && impactCol >= 0 && impactCol < matrix[row].Length)
                    {
                        matrix[row][impactCol] = 0;
                    }
                }

                for (int col = impactCol - impactRange; col <= impactCol + impactRange; col++)
                {
                    if (impactRow >= 0 && impactRow < matrix.Length && col >= 0 && col < matrix[impactRow].Length)
                    {
                        matrix[impactRow][col] = 0;
                    }
                }

                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i].Contains(0))
                    {
                        matrix[i] = matrix[i].Where(e => e != 0).ToArray();
                    }
                }

                matrix = matrix.Where(m => m.Count() != 0).ToArray();
                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }


        public static void FillMatrix(int[][] matrix, int cols)
        {
            int number = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = number;
                    number++;
                }
            }
        }
    }
}

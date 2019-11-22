namespace _12._String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringMatrixRotation
    {
        public static void Main()
        {
            string[] token = Console.ReadLine().Split("Rotate(", StringSplitOptions.RemoveEmptyEntries);
            int initialDegrees = int.Parse(token[0].Remove(token[0].Length - 1));
            int actualDegrees = (initialDegrees / 90) % 4;
            //0 = 0 degrees rotation
            //1 = 90 degrees rotation
            //2 = 180 degrees rotation
            //3 = 270 degrees rotation
            string input = Console.ReadLine();
            List<string> words = new List<string>();
            while (input != "END")
            {
                words.Add(input);
                input = Console.ReadLine();
            }

            int maxWordLength = words.Select(x => x.Length).Max();
            char[,] matrix = new char[words.Count, maxWordLength];
            FillMatrix(matrix, words);

            if (actualDegrees == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }
            }
            else if (actualDegrees == 1)
            {
                for (int row = 0; row <matrix.GetLength(1); row++)
                {
                    for (int col = matrix.GetLength(0)-1; col >=0; col--)
                    {
                        Console.Write(matrix[col, row]);
                    }

                    Console.WriteLine();
                }
            }
            else if (actualDegrees == 2)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }
            }
            else if (actualDegrees == 3)
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        Console.Write(matrix[col, row]);
                    }

                    Console.WriteLine();
                }
            }
        }

        public static void FillMatrix(char[,] matrix, List<string> words)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentWord = words[row];
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (currentWord.Length > col)
                    {
                        matrix[row, col] = currentWord[col];
                    }
                    else
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }
    }
}

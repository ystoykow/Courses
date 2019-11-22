using System;
using System.ComponentModel;
using System.Linq;

namespace _6._Target_Practice
{
    public class TargetPractice
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            int[] hitBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int impactRow = hitBox[0];
            int impactCol = hitBox[1];
            int impactRange = hitBox[2];
            char[,] matrix = new char[rows, cols];
            int counter = 0;
            int rowCounter = 0;

            FillMatrix(matrix, text, counter, rowCounter);
            Impact(matrix, impactRow, impactCol, impactRange);
            FallDown(matrix);
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void FallDown(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] != ' ' && matrix[row + 1, col] == ' ')
                        {
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = ' ';
                        }
                    }
                }
            }
        }

        public static void Impact(char[,] matrix, int impactRow, int impactCol, int impactRange)
        {
            matrix[impactRow, impactCol] = ' ';
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row - impactRow) *
                        (row - impactRow) +
                        (col - impactCol) *
                        (col - impactCol)
                        <= impactRange * impactRange)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        public static void FillMatrix(char[,] matrix, string text, int counter, int rowCounter)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                counter = FillRow(matrix, text, row, counter, rowCounter);
                rowCounter++;
            }
        }

        public static int FillRow(char[,] matrix, string text, int row, int counter, int rowCounter)
        {
            if (rowCounter % 2 == 0)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    if (counter >= text.Length)
                    {
                        counter = 0;
                    }

                    matrix[row, col] = text[counter];
                    counter++;
                }
            }
            else
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (counter >= text.Length)
                    {
                        counter = 0;
                    }

                    matrix[row, col] = text[counter];
                    counter++;
                }
            }

            return counter;
        }
    }
}

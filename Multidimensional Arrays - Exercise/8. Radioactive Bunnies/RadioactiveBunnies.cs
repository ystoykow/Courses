namespace _8._Radioactive_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RadioactiveBunnies
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int[] deadCoords = new int[2];
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix);
            string moves = Console.ReadLine();
            for (int i = 0; i < moves.Length; i++)
            {
                char direction = moves[i];
                bool isWinOrDead = Move(matrix, direction, deadCoords);
                if (isWinOrDead)
                {
                    break;
                }
            }
        }

        public static void GetBunnyCoords(char[,] matrix, int[] deadCoords)
        {
            List<int[]> bunniesCoords = new List<int[]>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        int[] currentCoords = new int[2];
                        currentCoords[0] = row;
                        currentCoords[1] = col;
                        bunniesCoords.Add(currentCoords);
                    }
                }
            }

            SpreadBunnies(matrix, bunniesCoords, deadCoords);
        }

        public static bool Move(char[,] matrix, char direction, int[] deadCoords)
        {
            bool isWinOrDead = false;
            int playerRow = -1;
            int playerCol = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            if (playerRow != -1)
            {
                if (direction == 'U')
                {
                    isWinOrDead = MoveUp(matrix, playerRow, playerCol, deadCoords);
                }
                else if (direction == 'D')
                {
                    isWinOrDead = MoveDown(matrix, playerRow, playerCol, deadCoords);
                }
                else if (direction == 'L')
                {
                    isWinOrDead = MoveLeft(matrix, playerRow, playerCol, deadCoords);
                }
                else if (direction == 'R')
                {
                    isWinOrDead = MoveRight(matrix, playerRow, playerCol, deadCoords);
                }
            }
            else
            {
                PrintMatrix(matrix);
                Console.WriteLine($"dead: {deadCoords[0]} {deadCoords[1]}");
                return true;
            }

            if (isWinOrDead)
            {
                return isWinOrDead;
            }

            GetBunnyCoords(matrix, deadCoords);
            return isWinOrDead;
        }

        public static void SpreadBunnies(char[,] matrix, List<int[]> coordinates, int[] deadCoords)
        {
            for (int i = 0; i < coordinates.Count; i++)
            {
                int row = coordinates[i][0];
                int col = coordinates[i][1];
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col] == 'P')
                    {
                        deadCoords[0] = row - 1;
                        deadCoords[1] = col;
                    }

                    matrix[row - 1, col] = 'B';
                }

                if (row + 1 < matrix.GetLength(0))
                {
                    if (matrix[row + 1, col] == 'P')
                    {
                        deadCoords[0] = row + 1;
                        deadCoords[1] = col;
                    }

                    matrix[row + 1, col] = 'B';
                }

                if (col - 1 >= 0)
                {
                    if (matrix[row, col - 1] == 'P')
                    {
                        deadCoords[0] = row;
                        deadCoords[1] = col - 1;
                    }

                    matrix[row, col - 1] = 'B';
                }

                if (col + 1 < matrix.GetLength(1))
                {
                    if (matrix[row, col + 1] == 'P')
                    {
                        deadCoords[0] = row;
                        deadCoords[1] = col + 1;
                    }

                    matrix[row, col + 1] = 'B';
                }
            }
        }

        public static bool MoveRight(char[,] matrix, int row, int col, int[] deadCoords)
        {
            if (matrix[row, col] == 'P')
            {
                if (col + 1 >= matrix.GetLength(1))
                {
                    GetBunnyCoords(matrix, deadCoords);
                    if (matrix[row, col] != 'B')
                    {
                        matrix[row, col] = '.';
                    }
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {row} {col}");
                    return true;
                }
                else if (matrix[row, col + 1] != 'B')
                {
                    matrix[row, col + 1] = 'P';
                    matrix[row, col] = '.';
                }
                else
                {
                    GetBunnyCoords(matrix, deadCoords);
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {row} {col + 1}");
                    return true;
                }
            }

            return false;
        }

        public static bool MoveLeft(char[,] matrix, int row, int col, int[] deadCoords)
        {
            if (matrix[row, col] == 'P')
            {
                if (col - 1 < 0)
                {
                    GetBunnyCoords(matrix, deadCoords);
                    if (matrix[row, col] != 'B')
                    {
                        matrix[row, col] = '.';
                    }
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {row} {col}");
                    return true;
                }
                else if (matrix[row, col - 1] != 'B')
                {
                    matrix[row, col - 1] = 'P';
                    matrix[row, col] = '.';
                }
                else
                {
                    GetBunnyCoords(matrix, deadCoords);
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {row} {col - 1}");
                    return true;
                }
            }

            return false;
        }

        public static bool MoveDown(char[,] matrix, int row, int col, int[] deadCoords)
        {
            if (matrix[row, col] == 'P')
            {
                if (row + 1 >= matrix.GetLength(0))
                {

                    GetBunnyCoords(matrix, deadCoords);
                    if (matrix[row, col] != 'B')
                    {
                        matrix[row, col] = '.';
                    }
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {row} {col}");
                    return true;
                }
                else if (matrix[row + 1, col] != 'B')
                {
                    matrix[row + 1, col] = 'P';
                    matrix[row, col] = '.';
                }
                else
                {
                    GetBunnyCoords(matrix, deadCoords);
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {row + 1} {col}");
                    return true;
                }
            }

            return false;
        }

        public static bool MoveUp(char[,] matrix, int row, int col, int[] deadCoords)
        {
            if (matrix[row, col] == 'P')
            {
                if (row - 1 < 0)
                {
                    GetBunnyCoords(matrix, deadCoords);
                    if (matrix[row, col] != 'B')
                    {
                        matrix[row, col] = '.';
                    }
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {row} {col}");
                    return true;
                }
                else if (matrix[row - 1, col] != 'B')
                {
                    matrix[row - 1, col] = 'P';
                    matrix[row, col] = '.';
                }
                else
                {
                    GetBunnyCoords(matrix, deadCoords);
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {row - 1} {col}");
                    return true;
                }
            }

            return false;
        }

        public static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentColChars = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentColChars[col];
                }
            }
        }

        public static void PrintMatrix(char[,] matrix)
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
    }
}


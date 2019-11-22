namespace _02._Seashell_Treasure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] beach = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                beach[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            List<char> collected = new List<char>();
            int stolenShells = 0;
            string command = Console.ReadLine();
            while (command != "Sunset")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (tokens[0] == "Collect")
                {
                    if (CheckIsInBoundary(row, col, beach))
                    {
                        if (CheckIsShell(beach, row, col))
                        {
                            collected.Add(beach[row][col]);
                            beach[row][col] = '-';
                        }
                    }
                }
                else if (tokens[0] == "Steal")
                {
                    string direction = tokens[3];
                    if (CheckIsInBoundary(row, col, beach))
                    {
                        if (CheckIsShell(beach, row, col))
                        {
                            stolenShells++;
                            beach[row][col] = '-';
                        }

                        for (int i = 1; i <= 3; i++)
                        {
                            if (direction == "up")
                            {
                                if (CheckIsInBoundary(row - i, col, beach))
                                {
                                    if (CheckIsShell(beach, row-i, col))
                                    {
                                        stolenShells++;
                                        beach[row - i][col] = '-';
                                    }
                                }
                            }
                            else if (direction == "down")
                            {
                                if (CheckIsInBoundary(row + i, col, beach))
                                {
                                    if (CheckIsShell(beach, row+i, col))
                                    {
                                        stolenShells++;
                                        beach[row + i][col] = '-';
                                    }
                                }
                            }
                            else if (direction == "left")
                            {
                                if (CheckIsInBoundary(row, col - i, beach))
                                {
                                    if (CheckIsShell(beach, row, col-i))
                                    {
                                        stolenShells++;
                                        beach[row][col - i] = '-';
                                    }
                                }
                            }
                            else if (direction == "right")
                            {
                                if (CheckIsInBoundary(row, col + i, beach))
                                {
                                    if (CheckIsShell(beach, row, col+i))
                                    {
                                        stolenShells++;
                                        beach[row][col + i] = '-';
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var row in beach)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            string result = string.Empty;
            if (collected.Count > 0)
            {
                result = $"Collected seashells: {collected.Count} -> {string.Join(", ", collected)}";
            }
            else
            {
                result = $"Collected seashells: {collected.Count}";
            }

            Console.WriteLine(result);
            Console.WriteLine($"Stolen seashells: {stolenShells}");
        }

        private static bool CheckIsShell(char[][] beach, int row, int col)
        {
            if (beach[row][col] != '-')
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsInBoundary(int row, int col, char[][] beach)
        {
            if (beach.Length > row
                && row >= 0
                && col >= 0
                && beach[row].Length > col)
            {
                return true;
            }

            return false;
        }
    }
}

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03._Space_Station_Establishment
{
    public class Program
    {
        public static void Main()
        {
            int dimension = int.Parse(Console.ReadLine());
            char[][] matrix = new char[dimension][];
            for (int i = 0; i < dimension; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int collectedEnergy = 0;
            bool isLost = false;
            bool haveMats = false;
            bool isFound = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'S')
                    {
                        Player.Row = i;
                        Player.Col = j;
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            while (!isLost && !haveMats)
            {
                string command = Console.ReadLine();
                matrix[Player.Row][Player.Col] = '-';
                Player.Move(command);
                if (Player.CheckIsInUniverse(matrix))
                {
                    if (char.IsDigit(matrix[Player.Row][Player.Col]))
                    {
                        collectedEnergy += (int)char.GetNumericValue(matrix[Player.Row][Player.Col]);
                        matrix[Player.Row][Player.Col] = 'S';
                    }
                    else if (matrix[Player.Row][Player.Col] == 'O')
                    {
                        matrix[Player.Row][Player.Col] = '-';
                        int[] blackHolesCoordinates = FindBlackHoles(matrix);
                        Player.Row = blackHolesCoordinates[0];
                        Player.Col = blackHolesCoordinates[1];
                        matrix[Player.Row][Player.Col] = 'S';
                    }
                    else
                    {
                        matrix[Player.Row][Player.Col] = 'S';
                    }

                    if (collectedEnergy >= 50)
                    {
                        haveMats = true;
                    }
                }
                else
                {
                    isLost = true;
                }
            }

            if (isLost)
            {
                Console.WriteLine($"Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {collectedEnergy}");
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }

        private static int[] FindBlackHoles(char[][] matrix)
        {
            int[] coords = new int[2];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'O')
                    {
                        coords[0] = i;
                        coords[1] = j;
                    }
                }
            }

            return coords;
        }


        private static class Player
        {
            public static int Row = 0;

            public static int Col = 0;

            public static void Move(string direction)
            {
                if (direction == "up")
                {
                    Row--;
                }
                else if (direction == "down")
                {
                    Row++;
                }
                else if (direction == "left")
                {
                    Col--;
                }
                else if (direction == "right")
                {
                    Col++;
                }
            }

            public static bool CheckIsInUniverse(char[][] matrix)
            {
                if (Player.Row < 0 
                    || Player.Row >= matrix.Length 
                    || Player.Col < 0 
                    ||Player.Col >= matrix[Player.Row].Length)
                {
                    return false;
                }

                return true;
            }
        }
    }
}

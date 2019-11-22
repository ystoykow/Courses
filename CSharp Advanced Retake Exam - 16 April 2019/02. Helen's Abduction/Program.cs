using System;

namespace _02._Helen_s_Abduction
{
    class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'P')
                    {
                        Paris.Row = i;
                        Paris.Col = j;
                    }
                }
            }

            bool isDead = false;
            bool isFound = false;
            while (!isDead && !isFound)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string direction = commands[0];
                int enemyRow = int.Parse(commands[1]);
                int enemyCol = int.Parse(commands[2]);
                field[enemyRow][enemyCol] = 'S';
                energy = Paris.Move(direction, field, energy);

                if (field[Paris.Row][Paris.Col] == 'S')
                {
                    energy -= 2;
                    if (energy <= 0)
                    {
                        field[Paris.Row][Paris.Col] = 'X';
                        isDead = true;
                    }
                    else
                    {
                        field[Paris.Row][Paris.Col] = 'P';
                    }
                }
                else if (field[Paris.Row][Paris.Col] == 'H')
                {
                    field[Paris.Row][Paris.Col] = '-';
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    isFound = true;
                }

                if (energy <= 0 && !isFound)
                {
                    field[Paris.Row][Paris.Col] = 'X';
                    Console.WriteLine($"Paris died at {Paris.Row};{Paris.Col}.");
                    isDead = true;
                }
            }

            for (int i = 0; i < field.Length; i++)
            {
                Console.WriteLine(string.Join("",field[i]));
            }
        }

        static class Paris
        {
            public static int Row;
            public static int Col;

            public static int Move(string direction, char[][] field, int energy)
            {
                field[Row][Col] = '-';
                if (direction == "up" && Row - 1 >= 0)
                {
                    Row--;
                }
                else if (direction == "down" && Row + 1 < field.Length)
                {
                    Row++;
                }
                else if (direction == "left" && Col - 1 >= 0)
                {
                    Col--;
                }
                else if (direction == "right" && Col + 1 < field[Row].Length)
                {
                    Col++;
                }

                if (field[Row][Col] == '-')
                {
                    field[Row][Col] = 'P';
                }

                return --energy;
            }
        }
    }
}

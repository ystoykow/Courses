namespace P06_Sneaking
{
    using System;

    public class Sneaking
    {
        public static void Main()
        {
            int roomDimensions = int.Parse(Console.ReadLine());
            char[][] room = new char[roomDimensions][];
            for (int row = 0; row < room.Length; row++)
            {
                room[row] = Console.ReadLine().ToCharArray();
            }

            char[] moves = Console.ReadLine().ToCharArray();

            Player playerSam = new Player('S');
            playerSam.FindPlayer(room);
            for (int i = 0; i < moves.Length; i++)
            {
                MoveEnemy(room);
                Enemy enemy = new Enemy();
                enemy.FindEnemy(room, playerSam);
                if (playerSam.IsDead(room, enemy))
                {
                    Console.WriteLine(playerSam.DeadMessage());
                    PrintRoom(room);
                    return;
                }

                room[playerSam.Row][playerSam.Col] = '.';
                playerSam.Move(moves[i]);
                room[playerSam.Row][playerSam.Col] = playerSam.Symbol;
                enemy.FindEnemy(room, playerSam);

                if (room[enemy.Row][enemy.Col] == 'N' && playerSam.Row == enemy.Row)
                {
                    room[enemy.Row][enemy.Col] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    PrintRoom(room);
                    return;
                }
            }
        }

        private static void PrintRoom(char[][] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(string.Join("", chars[i]));
            }
        }

        private static void MoveEnemy(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }
    }
}

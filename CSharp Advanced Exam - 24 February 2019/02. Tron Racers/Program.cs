namespace _02._Tron_Racers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[][] matrix = new char[dimensions][];
            Player firstPlayer = new Player();
            Player secondPlayer = new Player();

            for (int i = 0; i < dimensions; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 's')
                    {
                        secondPlayer.Row = i;
                        secondPlayer.Col = j;
                        secondPlayer.Symbol = 's';
                    }
                    else if (matrix[i][j] == 'f')
                    {
                        firstPlayer.Row = i;
                        firstPlayer.Col = j;
                        firstPlayer.Symbol = 'f';
                    }
                }
            }

            while (!firstPlayer.IsDead && !secondPlayer.IsDead)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                string firstPlayerCommand = commands[0];
                string secondPlayerCommand = commands[1];

                firstPlayer.Move(firstPlayerCommand, matrix);
                if (firstPlayer.IsDead)
                {
                    continue;
                }

                secondPlayer.Move(secondPlayerCommand, matrix);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
    }

    public class Player
    {
        public int Row;
        public int Col;
        public char Symbol;
        public bool IsDead;

        public void Move(string direction, char[][] matrix)
        {
            if (direction == "up")
            {
                this.Row--;
            }
            else if (direction == "down")
            {
                this.Row++;
            }
            else if (direction == "left")
            {
                this.Col--;
            }
            else if (direction == "right")
            {
                this.Col++;
            }

            IsOnOtherSide(matrix);
            LeftTrial(matrix);
        }

        private void LeftTrial(char[][] matrix)
        {
            if (matrix[Row][Col] != '*' && matrix[Row][Col] != this.Symbol)
            {
                matrix[Row][Col] = 'x';
                this.IsDead = true;
            }
            else
            {
                matrix[Row][Col] = this.Symbol;
            }
        }

        private void IsOnOtherSide(char[][] matrix)
        {
            if (this.Row >= matrix.Length)
            {
                this.Row = 0;
            }
            else if (this.Row < 0)
            {
                this.Row = matrix.Length - 1;
            }
            else if (this.Col >= matrix[Row].Length)
            {
                this.Col = 0;
            }
            else if (this.Col < 0)
            {
                this.Col = matrix[Row].Length - 1;
            }
        }
    }
}

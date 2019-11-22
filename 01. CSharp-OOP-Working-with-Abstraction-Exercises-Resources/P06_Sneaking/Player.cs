namespace P06_Sneaking
{
    public class Player
    {
        public Player(char symbol)
        {
            this.Symbol = symbol;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public char Symbol { get; set; }

        public void FindPlayer(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == this.Symbol)
                    {
                        this.Row = row;
                        this.Col = col;
                    }
                }
            }
        }

        public bool IsDead(char[][] room, Enemy enemy)
        {
            if ((this.Col < enemy.Col && room[enemy.Row][enemy.Col] == 'd' && enemy.Row == this.Row) ||
                (enemy.Col < this.Col && room[enemy.Row][enemy.Col] == 'b' && enemy.Row == this.Row))
            {
                room[this.Row][this.Col] = 'X';
                return true;
            }

            return false;
        }

        public void Move(char move)
        {
            switch (move)
            {
                case 'U':
                    this.Row--;
                    break;
                case 'D':
                    this.Row++;
                    break;
                case 'L':
                    this.Col--;
                    break;
                case 'R':
                    this.Col++;
                    break;
            }
        }

        public string DeadMessage()
        {
            return $"Sam died at {this.Row}, {this.Col}";
        }
    }
}

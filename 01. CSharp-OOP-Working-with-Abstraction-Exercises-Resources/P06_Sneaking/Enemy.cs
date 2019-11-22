namespace P06_Sneaking
{
    public class Enemy
    {
        public int Row { get; set; }

        public int Col { get; set; }

        public char Symbol { get; set; }

        public void FindEnemy(char[][] room, Player player)
        {
            for (int j = 0; j < room[player.Row].Length; j++)
            {
                if (room[player.Row][j] != '.' && room[player.Row][j] != player.Symbol)
                {
                    this.Symbol = room[player.Row][j];
                    this.Row = player.Row;
                    this.Col = j;
                }
            }
        }
    }
}

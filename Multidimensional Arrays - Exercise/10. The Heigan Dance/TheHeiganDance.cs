namespace _10._The_Heigan_Dance
{
    using System;

    public class TheHeiganDance
    {
        public static void Main()
        {
            int[,] chamber = new int[15, 15];
            Player player = new Player();
            player.Health = 18500;
            player.Damage = double.Parse(Console.ReadLine());
            player.IsDead = false;
            player.IsAffected = false;
            player.PositionRow = 7;
            player.PositionCol = 7;

            double heiganHealth = 3000000;
            bool isHeiganDead = false;
            FillMatrix(chamber);
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string spellName = input[0];
                int impactRow = int.Parse(input[1]);
                int impactCol = int.Parse(input[2]);
                if (!player.IsDead)
                {
                    if (!isHeiganDead)
                    {
                        heiganHealth -= player.Damage;
                        if (heiganHealth <= 0)
                        {
                            isHeiganDead = true;
                        }
                    }

                    if (player.IsAffected)
                    {
                        player.Health -= 3500;
                        player.IsAffected = false;
                        if (player.Health <= 0)
                        {
                            player.KilledBy = "Plague Cloud";
                            player.IsDead = true;
                        }
                    }
                }

                if (!isHeiganDead && !player.IsDead)
                {
                    CastSpell(spellName, impactRow, impactCol, chamber, player);
                    if (player.Health <= 0)
                    {
                        player.IsDead = true;
                    }
                }

                if (player.IsDead)
                {
                    Console.WriteLine(heiganHealth > 0 ? $"Heigan: {heiganHealth:f2}" : "Heigan: Defeated!");
                    Console.WriteLine($"Player: Killed by {player.KilledBy}");
                    Console.WriteLine($"Final position: {player.PositionRow}, {player.PositionCol}");
                    break;
                }

                if (isHeiganDead)
                {
                    Console.WriteLine("Heigan: Defeated!");
                    Console.WriteLine($"Player: {player.Health}");
                    Console.WriteLine($"Final position: {player.PositionRow}, {player.PositionCol}");
                    break;
                }

                FillMatrix(chamber);
            }
        }

        public class Player
        {
            public int Health { get; set; }

            public double Damage { get; set; }

            public bool IsAffected { get; set; }

            public bool IsDead { get; set; }

            public string KilledBy { get; set; }

            public int PositionRow { get; set; }

            public int PositionCol { get; set; }
        }

        public static void CastSpell(string spellName, int impactRow, int impactCol, int[,] chamber, Player player)
        {
            bool isPlayerInArea = false;
            for (int row = impactRow - 1; row <= impactRow + 1; row++)
            {
                for (int col = impactCol - 1; col <= impactCol + 1; col++)
                {
                    if (row >= 0 && row < chamber.GetLength(0) && col >= 0 && col < chamber.GetLength(1))
                    {
                        if (spellName == "Cloud")
                        {
                            chamber[row, col] = 3500;
                        }
                        else
                        {
                            chamber[row, col] = 6000;
                        }
                    }

                    if (player.PositionCol == col && player.PositionRow == row)
                    {
                        isPlayerInArea = true;
                    }
                }
            }

            if (isPlayerInArea)
            {
                TryMove(chamber, player, spellName);
            }
        }

        public static void TryMove(int[,] chamber, Player player, string spellName)
        {
            if (player.PositionRow - 1 >= 0 && chamber[player.PositionRow - 1, player.PositionCol] == 0)
            {
                player.PositionRow--;
            }
            else if (player.PositionCol + 1 < chamber.GetLength(1) && chamber[player.PositionRow, player.PositionCol + 1] == 0)
            {
                player.PositionCol++;
            }
            else if (player.PositionRow + 1 < chamber.GetLength(0) && chamber[player.PositionRow + 1, player.PositionCol] == 0)
            {
                player.PositionRow++;
            }
            else if (player.PositionCol - 1 >= 0 && chamber[player.PositionRow, player.PositionCol - 1] == 0)
            {
                player.PositionCol--;
            }
            else
            {
                if (spellName == "Cloud")
                {
                    player.Health -= 3500;
                    player.IsAffected = true;
                    if (player.Health <= 0)
                    {
                        player.KilledBy = "Plague Cloud";
                    }
                }
                else
                {
                    player.Health -= 6000;
                    if (player.Health <= 0)
                    {
                        player.KilledBy = "Eruption";
                    }
                }
            }
        }

        public static void FillMatrix(int[,] chamber)
        {
            for (int row = 0; row < chamber.GetLength(0); row++)
            {
                for (int col = 0; col < chamber.GetLength(1); col++)
                {
                    chamber[row, col] = 0;
                }
            }
        }
    }
}

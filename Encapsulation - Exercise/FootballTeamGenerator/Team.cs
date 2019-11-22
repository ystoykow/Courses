namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private List<Player> players;
        private string name;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating { get; private set; }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
            CalculateRating();
        }

        public void RemovePlayer(string name)
        {
            var removed = this.players.FirstOrDefault(p => p.Name == name);
            if (removed == null)
            {
                throw new ArgumentException($"Player {name} is not in {this.name} team.");
            }

            this.players.Remove(removed);
            CalculateRating();
        }

        private void CalculateRating()
        {
            this.Rating = this.players.Count==0 ? 0 : (int)Math.Round(this.players.Average(p => p.Average));
        }
    }
}

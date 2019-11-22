namespace PersonsInfo
{
    using System.Collections.Generic;

    public class Team
    {
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        private string name;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam=new List<Person>();
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public IReadOnlyList<Person> FirstTeam => this.firstTeam.AsReadOnly();

        public IReadOnlyList<Person> ReserveTeam => this.reserveTeam.AsReadOnly();


        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }
    }
}

namespace SpaceStationRecruitment
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data= new List<Astronaut>();
        }
        public string Name { get; }

        public int Capacity { get; }

        public int Count
        {
            get => this.data.Count;
        }

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            var currentAstronaut = this.data.FirstOrDefault(a => a.Name == name);
            if (currentAstronaut != null)
            {
                this.data.Remove(currentAstronaut);
                return true;
            }


            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            foreach (var item in this.data.OrderByDescending(x=>x.Age))
            {
                return item;
            }

            return null;
        }

        public Astronaut GetAstronaut(string name)
        {
            return this.data.FirstOrDefault(a => a.Name == name);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var astronaut in this.data)
            {
                sb.AppendLine($"{astronaut}");
            }

            return sb.ToString().Trim();
        }
    }
}

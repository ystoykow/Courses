namespace AquariumAdventure
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Aquarium
    {
        private List<Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            Name = name;
            Capacity = capacity;
            Size = size;
            fishInPool = new List<Fish>();
        }

        public string Name {get;  }

        public int Capacity { get; }

        public int Size { get; }


        public void Add(Fish fish)
        {
            if (this.fishInPool.Count<this.Capacity && !this.fishInPool.Any(f => f.Name.Equals(fish.Name)))
            {
                this.fishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            if (fishInPool.Any(f => f.Name.Equals(name)))
            {
                var currentFish = this.fishInPool.FirstOrDefault(f => f.Name.Equals(name));
                this.fishInPool.Remove(currentFish);
                return true;
            }

            return false;
        }

        public Fish FindFish(string name)
        {
            return this.fishInPool.FirstOrDefault(f => f.Name.Equals(name));
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");
            foreach (var fish in fishInPool)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}

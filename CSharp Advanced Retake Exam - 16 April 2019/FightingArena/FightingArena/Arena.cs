namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        public Arena(string name)
        {
            this.Name = name;
            this.gladiators= new List<Gladiator>();
        }

        public int Count
        {
            get { return this.gladiators.Count; }
        }

        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            this.gladiators = this.gladiators.Where(x => x.Name != name).ToList();
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            foreach (var gladiator in this.gladiators.OrderByDescending(g=>g.GetStatPower()))
            {
                return gladiator;
            }

            return null;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            foreach (var gladiator in this.gladiators.OrderByDescending(g => g.GetWeaponPower()))
            {
                return gladiator;
            }

            return null;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            foreach (var gladiator in this.gladiators.OrderByDescending(g => g.GetTotalPower()))
            {
                return gladiator;
            }

            return null;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}

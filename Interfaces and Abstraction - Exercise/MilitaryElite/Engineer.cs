namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;
        public Engineer(string firstName, string lastName, string id, decimal salary, string corps,
            params string[] repairs)
            : base(firstName, lastName, id, salary, corps)
        {
            this.repairs = new List<Repair>();
            AddRepairs(repairs);
        }

        public IReadOnlyCollection<Repair> Repairs => this.repairs;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var repair in this.Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().Trim();
        }

        private void AddRepairs(string[] repairs)
        {
            for (int i = 0; i < repairs.Length; i += 2)
            {
                string partName = repairs[i];
                int hours = int.Parse(repairs[i + 1]);
                Repair currentRepair = new Repair(partName, hours);
                this.repairs.Add(currentRepair);
            }
        }
    }
}

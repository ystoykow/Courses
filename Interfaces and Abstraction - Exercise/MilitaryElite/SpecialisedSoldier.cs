namespace MilitaryElite
{
    using System.Text;

    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary, string corps)
            : base(firstName, lastName, id, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    value = null;
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            return sb.ToString().Trim();
        }
    }
}

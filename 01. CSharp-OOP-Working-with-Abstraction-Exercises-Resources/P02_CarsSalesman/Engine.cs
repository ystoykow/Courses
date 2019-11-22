namespace P02_CarsSalesman
{
    using System.Text;

    public class Engine
    {
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.power = power;
            this.displacement = -1;
            this.efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
        : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
        : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power, displacement)
        {
            this.efficiency = efficiency;
        }

        public string Model { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("  {0}:\n", this.Model);
            sb.AppendFormat("    Power: {0}\n", this.power);
            sb.AppendFormat("    Displacement: {0}\n", this.displacement == -1 ? "n/a" : this.displacement.ToString());
            sb.AppendFormat("    Efficiency: {0}\n", this.efficiency);

            return sb.ToString();
        }
    }
}

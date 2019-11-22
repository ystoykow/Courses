namespace P02_CarsSalesman
{
    using System.Text;

    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            :this(model, engine, weight)
        {
            this.color = color;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.model}:\n");
            sb.Append(this.engine.ToString());
            sb.AppendFormat("  Weight: {0}\n", this.weight == -1 ? "n/a" : this.weight.ToString());
            sb.AppendFormat("  Color: {0}",  this.color);

            return sb.ToString().Trim();
        }
    }
}

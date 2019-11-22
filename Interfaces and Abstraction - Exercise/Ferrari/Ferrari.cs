namespace Ferrari
{
    public class Ferrari :ICar
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Driver { get; }

        public string Model { get; }

        public string Gas()
        {
            return "Gas!";
        }

        public string Break()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Break()}/{this.Gas()}/{this.Driver}";
        }
    }
}

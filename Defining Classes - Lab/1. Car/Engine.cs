namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsepower, double cubicCapacity)
        {
            this.HorsePower = horsepower;
            this.CubicCapacity = cubicCapacity;
        }

        private int horsePower;
        private double cubicCapacity;

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }

        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }
            set
            {
                this.cubicCapacity = value;
            }
        }
    }
}

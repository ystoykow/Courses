namespace MilitaryElite
{
    public class Repair:IRepair
    {
        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.Hours = hours;
        }

        public string PartName { get; }
        public int Hours { get; }

        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.Hours}";
        }
    }
}

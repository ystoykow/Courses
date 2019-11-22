namespace P05_GreedyTimes
{
    public class Item
    {
        public Item(string name ,long amount)
        {
            this.Name = name;
            this.Amount = amount;
        }

        public string Name { get; set; }

        public long Amount { get; set; }
    }
}

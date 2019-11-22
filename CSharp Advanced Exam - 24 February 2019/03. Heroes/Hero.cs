namespace Heroes
{
    using System.Text;

    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            this.Item = item;
            this.Level = level;
            this.Name = name;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Hero: {Name} – {Level}lvl");
            sb.AppendLine($"Item:");
            sb.AppendLine($"{this.Item}");
            return sb.ToString().Trim();
        }
    }
}

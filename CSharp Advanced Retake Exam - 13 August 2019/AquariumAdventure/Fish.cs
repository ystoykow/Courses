namespace AquariumAdventure
{
    using System.Text;

    public class Fish
    {
        public Fish(string name, string color, int fins)
        {
            Name = name;
            Color = color;
            Fins = fins;
        }

        public string Name { get; }

        public string Color { get; }

        public int Fins { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Fish: {Name}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Number of fins: {Fins}");
            return sb.ToString().Trim();
        }
    }
}

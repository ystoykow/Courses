namespace MilitaryElite
{
    using System.Text;

    public class Spy :Soldier,ISpy
    {
        public Spy(string firstName, string lastName, string id,int codeNumber)
            : base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Code Number: {this.CodeNumber}");
            return sb.ToString().Trim();
        }
    }
}

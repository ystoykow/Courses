namespace MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private,ILietenantGeneral
    {
        public LieutenantGeneral(string firstName, string lastName, string id, decimal salary, List<Private> privates)
            : base(firstName, lastName, id, salary)
        {
            this.Privates = privates;
        }

        public IReadOnlyCollection<Private> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var @private in this.Privates)
            {
                sb.AppendLine($"  {@private}");
            }

            return sb.ToString().Trim();
        }
    }
}

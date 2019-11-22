namespace FightingArena
{
    using System.Text;

    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Stat = stat;
            this.Name = name;
            this.Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            return GetWeaponPower() + GetStatPower();
        }

        public int GetWeaponPower()
        {
            return Weapon.Solidity + Weapon.Sharpness + Weapon.Size;
        }

        public int GetStatPower()
        {
            return Stat.Skills + Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Strength;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"[{this.Name}] - [{GetTotalPower()}]");
            sb.AppendLine($" Weapon Power: [{GetWeaponPower()}]");
            sb.AppendLine($" Stat Power: [{GetStatPower()}]");
            return sb.ToString().Trim();
        }
    }
}

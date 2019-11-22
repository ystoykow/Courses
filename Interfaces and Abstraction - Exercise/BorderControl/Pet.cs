namespace BorderControl
{
    public class Pet :IBirthdable
    {
        public Pet(string name,string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; }

        public string Birthdate { get; }
    }
}

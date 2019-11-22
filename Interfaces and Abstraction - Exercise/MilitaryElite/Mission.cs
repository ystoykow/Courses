namespace MilitaryElite
{
    public class Mission :IMission
    {
        private string state;
        public Mission(string name, string state)
        {
            this.CodeName = name;
            this.State = state;
        }

        public string CodeName { get; }

        public string State
        {
            get => this.state;
            set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    this.state = null;
                }
                else
                {
                    this.state = value;
                }
            }
        }
        
        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.state}";
        }
    }
}

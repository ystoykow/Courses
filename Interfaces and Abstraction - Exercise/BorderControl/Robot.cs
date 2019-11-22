namespace BorderControl
{
    public class Robot :ICitizen
    {
        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; }

        public string Id { get; }
    }
}

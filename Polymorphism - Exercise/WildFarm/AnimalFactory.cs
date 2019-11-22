namespace WildFarm
{
    public static class AnimalFactory
    {
        public static Animal Create(string[] args)
        {
            string type = args[0];
            string name = args[1];
            double weight = double.Parse(args[2]);

            if (type == "Cat")
            {
                string livingRegion = args[3];
                string breed = args[4];
                return new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = args[3];
                string breed = args[4];
                return new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(args[3]);
                return new Hen(name, weight,wingSize);
            }
            else if (type == "Owl")
            {
                double wingSize = double.Parse(args[3]);
                return new Owl(name, weight, wingSize);
            }
            else if (type == "Dog")
            {
                string livingRegion = args[3];
                return new Dog(name, weight,livingRegion);
            }
            else if (type == "Mouse")
            {
                string livingRegion = args[3];
                return new Mouse(name, weight, livingRegion);
            }

            return null;
        }
    }
}

namespace WildFarm
{
    public static class FoodFactory
    {
        public static Food Create(string[] args)
        {
            string type = args[0];
            int quantity = int.Parse(args[1]);

            if (type == "Meat")
            {
                return new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                return new Seeds(quantity);
            }
            else if (type == "Fruit")
            {
                return new Fruit(quantity);
            }
            else if (type == "Vegetable")
            {
                return new Vegetable(quantity);
            }

            return null;
        }
    }
}

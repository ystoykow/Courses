namespace P05_GreedyTimes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private Dictionary<string, List<Item>> bag;
        private long capacity;
        private long freeSpace;
        public Bag(long capacity)
        {
            this.capacity = capacity;
            this.bag = new Dictionary<string, List<Item>>();
        }

        public void Add(string name, long amount)
        {
            string type = CheckType(name);
            Item item = new Item(name, amount);
            if (type == "Gem")
            {
                string param = "Gold";
                AddToBag(type, param, amount, item);
            }
            else if (type == "Cash")
            {
                string param = "Gem";
                AddToBag(type, param, amount, item);

            }
            else if (type == "Gold")
            {
                if (!bag.ContainsKey(type))
                {
                    bag.Add(type, new List<Item>());
                }

                if (capacity >= freeSpace + amount)
                {
                    CheckExistingItem(type,amount,item);
                }
            }
        }

        private void AddToBag(string type, string param, long amount, Item item)
        {
            if (!bag.ContainsKey(type))
            {
                this.bag.Add(type, new List<Item>());
            }

            if (this.bag.ContainsKey(param) &&
                this.bag[param].Sum(g => g.Amount) >= this.bag[type].Sum(i => i.Amount) + amount &&
                capacity >= freeSpace + amount)
            {
                CheckExistingItem(type, amount, item);
            }
        }

        private void CheckExistingItem(string type, long amount, Item item)
        {
            if (this.bag[type].Any(i => i.Name == item.Name))
            {
                Item first = null;
                foreach (var i in this.bag[type])
                {
                    if (i.Name == item.Name)
                    {
                        first = i;
                        break;
                    }
                }

                first.Amount += amount;
            }
            else
            {
                this.bag[type].Add(item);
            }

            freeSpace += amount;
        }

        private string CheckType(string name)
        {
            string type = string.Empty;

            if (name.Length == 3)
            {
                type = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                type = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                type = "Gold";
            }

            return type;
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var itemType in this.bag.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Sum(y => y.Amount)))
            {
                sb.AppendLine($"<{itemType.Key}> ${itemType.Value.Sum(x => x.Amount)}");

                foreach (var item in itemType.Value.OrderByDescending(i => i.Name).ThenBy(i => i.Amount))
                {
                    sb.AppendLine($"##{item.Name} - {item.Amount}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}

namespace CollectionHierarchy
{
    using System.Collections.Generic;

    public class AddCollection:IAdd
    {
        private List<string> addCollection;

        public AddCollection()
        {
            this.addCollection = new List<string>(100);
        }

        public string Add(string item)
        {
            if (this.addCollection.Count < this.addCollection.Capacity)
            {
                addCollection.Add(item);
            }

            return (addCollection.Count - 1).ToString();
        }
    }
}

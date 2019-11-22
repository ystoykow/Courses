namespace CollectionHierarchy
{
    using System.Collections.Generic;

    public class AddRemoveCollection :IAdd,IRemove
    {
        private List<string> addRemoveCollection;
        public AddRemoveCollection()
        {
            this.addRemoveCollection= new List<string>(100);
        }

        public string Add(string item)
        {
            int indexOfAdd = 0;
            if (this.addRemoveCollection.Count < this.addRemoveCollection.Capacity)
            {
                this.addRemoveCollection.Insert(indexOfAdd, item);
            }

            return indexOfAdd.ToString();
        }

        public virtual string Remove()
        {
            string element = this.addRemoveCollection[this.addRemoveCollection.Count - 1];
            this.addRemoveCollection.RemoveAt(this.addRemoveCollection.Count - 1);
            return element;
        }
    }
}

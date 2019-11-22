namespace CollectionHierarchy
{
    using System.Collections.Generic;

    public class MyList : IAdd,IRemove, IUsed
    {
        private List<string> myList;

        public MyList()
        {
            this.myList = new List<string>(100);
        }

        public int Used => this.myList.Count;
        public string Add(string item)
        {
            int indexOfAdd = 0;
            if (this.myList.Count < this.myList.Capacity)
            {
                this.myList.Insert(indexOfAdd, item);
            }

            return indexOfAdd.ToString();
        }

        public string Remove()
        {
            string element = this.myList[0];
            this.myList.RemoveAt(0);
            return element;
        }
    }
}

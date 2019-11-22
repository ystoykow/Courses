namespace BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private List<T> box;

        public Box()
        {
            this.box = new List<T>();
        }

        public int Count => this.box.Count;

        public void Add(T element)
        {
            this.box.Add(element);
        }

        public T Remove()
        {
            var lastItem = this.box.LastOrDefault();
            this.box.RemoveAt(this.box.Count-1);
            return lastItem;
        }
    }
}

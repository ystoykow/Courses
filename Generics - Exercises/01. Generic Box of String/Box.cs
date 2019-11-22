namespace GenericsExercise
{
    using System.Collections.Generic;
    using System.Text;
    using System;

    public class Box<T>
    {
        private List<T> collection;

        public Box()
        {
            this.collection = new List<T>();
        }

        public List<T> Collection => this.collection;
        public void Add(T item)
        {
            this.collection.Add(item);
        }

        public int CountOfGraterItems<T>(List<T> items, T element) where T : IComparable<T>

        {
            int greaterElements = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(element) > 0)
                {
                    greaterElements++;
                }
            }

            return greaterElements;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in collection)
            {
                sb.AppendLine($"{typeof(T)}: {element}");
            }

            return sb.ToString();
        }
    }
}

using System.Collections;

namespace ListyIterator
{
    using System;
    using System.Collections.Generic;

    public class ListyIterator<T> :IEnumerable<T>
    {
        private List<T> innerList;
        private int index;

        public void Create(params T[] args)
        {
            this.innerList = new List<T>(args);
        }

        public bool Move()
        {
            if (this.index + 1 < this.innerList.Count)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return this.index + 1 < this.innerList.Count;
        }

        public void Print()
        {
            CheckIsEmpty();
            Console.WriteLine(this.innerList[this.index]);
        }

        public void PrintAll()
        {
            CheckIsEmpty();

            foreach (var item in this.innerList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.innerList.Count; i++)
            {
                yield return this.innerList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void CheckIsEmpty()
        {
            if (this.innerList.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}

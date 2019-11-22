using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class CustomStack<T> :IEnumerable<T>
    {
        private List<T> innerList = new List<T>();

        public void Push(params T[] args)
        {
            this.innerList.AddRange(args);
        }

        public T Pop()
        {
            if (this.innerList.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T element = this.innerList[this.innerList.Count - 1];
            this.innerList.RemoveAt(this.innerList.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.innerList.Count-1; i >=0  ; i--)
            {
                yield return this.innerList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

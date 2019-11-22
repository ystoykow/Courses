namespace CustomLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomLinkedList<T> :IEnumerable<T>
    {
        private class ListNodes
        {
            public T Value { get; }

            public ListNodes NextNode { get; set; }

            public ListNodes PrevNode { get; set; }

            public ListNodes(T value)
            {
                this.Value = value;
            }
        }

        private ListNodes tail;
        private ListNodes head;

        public int Count { get; private set; } = 0;

        public CustomLinkedList()
        {
            List<ListNodes> linkedList = new List<ListNodes>();
        }

        public void AddFirst(T element)
        {
            if (CheckIsEmpty())
            {
                this.head = this.tail = new ListNodes(element);
            }
            else
            {
                var newHead = new ListNodes(element);
                newHead.NextNode = this.head;
                this.head.PrevNode = newHead;
                this.head = newHead;
                newHead.PrevNode = default;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            if (CheckIsEmpty())
            {
                this.tail = this.head = new ListNodes(element);
            }
            else
            {
                var newTail = new ListNodes(element);
                newTail.PrevNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
                newTail.NextNode = default;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (CheckIsEmpty())
            {
                throw new InvalidOperationException();
            }

            var firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head != default)
            {
                this.head.PrevNode = default;
            }
            else
            {
                this.tail = default;
            }

            Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            if (CheckIsEmpty())
            {
                throw new InvalidOperationException();
            }

            var lastElement = this.tail.Value;
            this.tail = this.tail.PrevNode;
            if (this.tail != default)
            {
                this.tail.NextNode = default;
            }
            else
            {
                this.head = default;
            }

            Count--;
            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != default)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            int counter = 0;
            var currentNode = this.head;
            while (currentNode != default)
            {
                arr[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }

            return arr;
        }

        private bool CheckIsEmpty()
        {
            return this.Count == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != default)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

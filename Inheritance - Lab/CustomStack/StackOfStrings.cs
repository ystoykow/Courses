namespace CustomStack
{
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<string> AddRange(string[] args)
        {
            foreach (var item in args)
            {
                this.Push(item);
            }

            return this;
        }
    }
}

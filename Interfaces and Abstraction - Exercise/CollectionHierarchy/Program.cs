using System.Text;

namespace CollectionHierarchy
{
    using System;

    public class Program
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int elementsToRemove = int.Parse(Console.ReadLine());

            StringBuilder addSB = new StringBuilder();
            StringBuilder addRemoveSB = new StringBuilder();
            StringBuilder myListSB = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                addSB.Append($"{addCollection.Add(input[i])} ");
                addRemoveSB.Append($"{addRemoveCollection.Add(input[i])} ");
                myListSB.Append($"{myList.Add(input[i])} ");
            }

            Console.WriteLine(addSB.ToString().Trim());
            Console.WriteLine(addRemoveSB.ToString().Trim());
            Console.WriteLine(myListSB.ToString().Trim());

            addRemoveSB.Clear();
            myListSB.Clear();

            for (int i = 0; i < elementsToRemove; i++)
            {
                addRemoveSB.Append($"{addRemoveCollection.Remove()} ");
                myListSB.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(addRemoveSB.ToString().Trim());
            Console.WriteLine(myListSB.ToString().Trim());
        }
    }
}

namespace Stack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            CustomStack<string> collection = new CustomStack<string>();
            while (input[0] != "END")
            {
                if (input[0] == "Push")
                {
                    collection.Push(input.Skip(1).ToArray());
                }
                else if (input[0] == "Pop")
                {
                    try
                    {
                        collection.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

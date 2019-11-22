namespace ListyIterator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            ListyIterator<string> collection = new ListyIterator<string>();
            collection.Create(input.Skip(1).ToArray());

            while (input[0] != "END")
            {
                if (input[0] == "Move")
                {
                    Console.WriteLine(collection.Move());
                }
                else if (input[0] == "HasNext")
                {
                    Console.WriteLine(collection.HasNext());
                }
                else if (input[0] == "Print")
                {
                    try
                    {
                        collection.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (input[0] == "PrintAll")
                {
                    try
                    {
                        collection.PrintAll();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}

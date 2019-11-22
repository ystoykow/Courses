namespace _05._Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppliedArithmetics
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            Func<List<int>, List<int>> addFunc = x => x.Select(n => n+=1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(n => n *= 2).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(n => n-=1).ToList();
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            while (input != "end")
            {
                if (input == "add")
                {
                    numbers=addFunc(numbers);
                }
                else if (input == "multiply")
                {
                   numbers= multiplyFunc(numbers);
                }
                else if (input == "subtract")
                {
                   numbers= subtractFunc(numbers);
                }
                else
                {
                    print(numbers);
                }

                input = Console.ReadLine();
            }
        }
    }
}

namespace _3._Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> inputs = new Stack<string>(input.Reverse());
            
            int sum = int.Parse(inputs.Pop());

            while (inputs.Count != 0)
            {
                string currentOperator = inputs.Pop();

                if (currentOperator == "+")
                {
                    sum += int.Parse(inputs.Pop());
                }
                else if (currentOperator == "-")
                {
                    sum -= int.Parse(inputs.Pop());
                }
            }

            Console.WriteLine(sum);
        }
    }
}

namespace _4._Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class MatchingBrackets
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> bracketsIndex = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '(')
                {
                    bracketsIndex.Push(i);
                }
                else if (input[i] == ')')
                {
                    string result = string.Empty;
                    int firstBracket = bracketsIndex.Pop();

                    for (int j = firstBracket; j <= i; j++)
                    {
                        result += input[j];
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}

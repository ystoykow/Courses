namespace _08._Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesis
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> openBracket = new Stack<char>();

            bool isBalanced = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[' || input[i] == '(' || input[i] == '{')
                {
                    openBracket.Push(input[i]);
                }
                else if (openBracket.Count > 0)
                {
                    char currentOpen = openBracket.Pop();
                    if (currentOpen == '[' && input[i] == ']')
                    {
                        isBalanced = true;
                    }
                    else if (currentOpen == '(' && input[i] == ')')
                    {
                        isBalanced = true;
                    }
                    else if (currentOpen == '{' && input[i] == '}')
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

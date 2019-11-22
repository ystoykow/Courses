namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;

    public class SimpleTextEditor
    {
        public static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            string text = "";
            Stack<string> backup = new Stack<string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string commandName = tokens[0];

                if (commandName == "1" || commandName == "2")
                {
                    string args = tokens[1];
                    backup.Push(text);
                    if (commandName == "1")
                    {
                        text += args;
                    }
                    else
                    {
                        string result = string.Empty;
                        int charsToRemove = int.Parse(args);
                        for (int j = 0; j < text.Length - charsToRemove; j++)
                        {
                            result += text[j];
                        }

                        text = result;
                    }
                }
                else if (commandName == "3")
                {

                    string args = tokens[1];
                    int indexOf = int.Parse(args);
                    if (indexOf < text.Length || indexOf > 0)
                    {
                        Console.WriteLine(text[indexOf - 1]);
                    }
                }
                else if (commandName == "4")
                {
                    if (backup.Count > 0)
                    {
                        text = backup.Pop();
                    }
                }
            }
        }
    }
}
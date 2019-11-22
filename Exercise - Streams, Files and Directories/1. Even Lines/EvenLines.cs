namespace _1._Even_Lines
{
    using System;
    using System.IO;

    public class EvenLines
    {
        public static void Main()
        {
            int counter = 0;
            using (var reader = new StreamReader("Resources/text.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 == 0)
                    {
                        string[] result = line.Split(new[] {'-', ',', '.', '!', '?'});
                        string str = string.Join("@", result);
                        string[] finalResult = str.Split(" ");
                        Array.Reverse(finalResult);
                        Console.WriteLine(string.Join(" ",finalResult));
                    }

                    counter++;
                }
            }
        }
    }
}

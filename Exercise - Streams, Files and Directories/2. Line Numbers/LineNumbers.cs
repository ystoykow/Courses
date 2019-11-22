using System;
using System.IO;

namespace _2._Line_Numbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            using (var reader = new StreamReader("Resources/text.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    int counter = 1;
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        int countChar = 0;
                        int countSymbol = 0;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsPunctuation(line[i]))
                            {
                                countSymbol++;
                            }
                            else if(char.IsLetter(line[i]))
                            {
                                countChar++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({countChar})({countSymbol})");
                        counter++;
                    }
                }
            }
        }
    }
}

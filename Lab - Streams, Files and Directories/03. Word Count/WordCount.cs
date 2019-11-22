namespace _03._Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            Dictionary<string, int> repeats = new Dictionary<string, int>();
            using (var reader = new StreamReader("words.txt"))
            {
                string[] words = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (!repeats.ContainsKey(word))
                    {
                        repeats.Add(word, 0);
                    }
                }
            }

            using (var reader = new StreamReader("text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] currentWords = line.ToLower().Split(new[] { ',', '-', ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < currentWords.Length; i++)
                    {
                        string currentWord = currentWords[i];
                        if (repeats.ContainsKey(currentWord))
                        {
                            repeats[currentWord]++;
                        }
                    }
                }
            }

            using (var writer = new StreamWriter("output.txt"))
            {
                foreach (var word in repeats.OrderByDescending(x=>x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}

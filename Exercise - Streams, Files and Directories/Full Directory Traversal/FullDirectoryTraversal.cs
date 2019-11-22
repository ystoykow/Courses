namespace Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var files = Directory.GetFiles(input, "*.*", SearchOption.AllDirectories);
            Dictionary<string, Dictionary<string, double>> extensions = new Dictionary<string, Dictionary<string, double>>();
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                if (!extensions.ContainsKey(info.Extension))
                {
                    extensions.Add(info.Extension, new Dictionary<string, double>());
                }

                if (!extensions[info.Extension].ContainsKey(info.Name))
                {
                    extensions[info.Extension].Add(info.Name, info.Length);
                }
            }

            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/output.txt";
            using (var writer = new StreamWriter(pathToDesktop))
            {
                foreach (var kvp in extensions.OrderByDescending(x => x.Value.Values.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(kvp.Key);
                    foreach (var innerKvp in kvp.Value.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"--{innerKvp.Key} - {innerKvp.Value / 1024:f3}kb");
                    }
                }
            }
        }
    }
}

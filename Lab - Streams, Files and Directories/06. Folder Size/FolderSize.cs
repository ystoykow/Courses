namespace _06._Folder_Size
{
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            var dir = new DirectoryInfo("Resources/06. Folder Size/TestFolder");
            long total = 0;
            foreach (var file in dir.GetFiles())
            {
                total += file.Length;
            }

            using (var writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine($"{total/1024/1024}MB");
            }
        }
    }
}

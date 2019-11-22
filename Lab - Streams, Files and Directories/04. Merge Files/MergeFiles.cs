namespace _04._Merge_Files
{
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            using (var firstReader = new StreamReader("FileOne.txt"))
            {
                using (var secondReader = new StreamReader("FileTwo.txt"))
                {
                    using (var writer = new StreamWriter("output.txt"))
                    {
                        while (true)
                        {
                            string firstLine = firstReader.ReadLine();
                            string secondLine = secondReader.ReadLine();
                            if (firstLine == null)
                            {
                                break;
                            }

                            writer.WriteLine(firstLine);
                            writer.WriteLine(secondLine);
                        }
                    }
                }
            }
        }
    }
}

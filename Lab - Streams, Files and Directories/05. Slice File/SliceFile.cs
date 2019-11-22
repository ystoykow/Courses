namespace _05._Slice_File
{
    using System.IO;

    public class SliceFile
    {
        public static void Main()
        {
            using (var reader = new FileStream("sliceMe.txt", FileMode.Open))
            {
                var partSize = reader.Length / 4;
                byte[] buffer = new byte[4096];
                for (int i = 1; i <= 4; i++)
                {
                    using (var writer = new FileStream($"Part-{i}.txt", FileMode.Create))
                    {
                        var currentSize = 0;
                        while (currentSize <= partSize)
                        {
                            var totalRead = reader.Read(buffer, 0, buffer.Length);
                            currentSize += totalRead;
                            writer.Write(buffer, 0, totalRead);
                            if (totalRead == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}

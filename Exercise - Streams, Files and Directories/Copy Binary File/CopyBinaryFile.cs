namespace Copy_Binary_File
{
    using System.IO;

    public class CopyBinaryFile
    {
        public static void Main()
        {
            using (var reader = new FileStream("Resources/copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream("output.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int size = reader.Read(buffer, 0, buffer.Length);
                        if (size == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, size);
                    }
                }
            }
        }
    }
}

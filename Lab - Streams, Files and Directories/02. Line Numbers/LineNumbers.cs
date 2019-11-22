namespace _02._Line_Numbers
{
    using System.IO;

   public class LineNumbers
    {
        public static void Main()
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                int counter = 1;
                using (var writer = new StreamWriter("output.txt"))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}

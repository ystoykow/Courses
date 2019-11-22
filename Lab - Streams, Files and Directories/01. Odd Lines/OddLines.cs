namespace _01._Odd_Lines
{
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                int counter = 0;
                using (var writer = new StreamWriter("output.txt"))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}

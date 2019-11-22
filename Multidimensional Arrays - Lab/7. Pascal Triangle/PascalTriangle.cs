namespace _7._Pascal_Triangle
{
    using System;

    public class PascalTriangle
    {
        public static void Main()
        {
            int dimensions = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[dimensions][];

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (col > 0 && col < pascalTriangle[row].Length-1)
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col] + pascalTriangle[row - 1][col - 1];
                    }
                    else
                    {
                        pascalTriangle[row][col] = 1;
                    }
                }
            }

            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
            }
        }
    }
}

namespace _6._Jagged_Array_Modification
{
    using System;
    using System.Linq;

    public class JaggedArrayModification
    {
        public static void Main()
        {
            int dimensions = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[dimensions][];
            for (int i = 0; i < dimensions; i++)
            {
                jaggedMatrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string commands = Console.ReadLine();
            while (commands != "END")
            {
                string[] tokens = commands.Split();
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if (row < 0 || row >= jaggedMatrix.Length || col < 0 || col >= jaggedMatrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command == "Add")
                {
                    jaggedMatrix[row][col] += value;
                }
                else
                {
                    jaggedMatrix[row][col] -= value;
                }

                commands = Console.ReadLine();
            }

            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ",jaggedMatrix[row]));
            }
        }
    }
}

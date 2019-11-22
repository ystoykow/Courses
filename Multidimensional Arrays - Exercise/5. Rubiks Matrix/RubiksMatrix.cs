namespace _5._Rubiks_Matrix
{
    using System;
    using System.Linq;
    using System.Text;

    public class RubiksMatrix
    {
        public static void Main()
        {
            int[] rubikCubeSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int countCommands = int.Parse(Console.ReadLine());
            int rows = rubikCubeSize[0];
            int cols = rubikCubeSize[1];
            int[,] rubikCube = new int[rows, cols];
            int[,] originalRubikCube = new int[rows, cols];
            int number = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    rubikCube[row, col] = number;
                    originalRubikCube[row, col] = number;
                    number++;
                }
            }

            for (int i = 0; i < countCommands; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int rowOrCol = int.Parse(input[0]);
                string direction = input[1];
                int moves = int.Parse(input[2]);
                int[] currentSide = new int[cols];

                FillCurrentSide(currentSide, rubikCube, rowOrCol, direction);
                ShuffleCurrentSide(currentSide, moves, direction);
                GetShuffledSide(rubikCube, currentSide, rowOrCol, direction);
            }

            int[,] tempRubikCube = new int[1, 1];
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (originalRubikCube[row, col] == rubikCube[row, col])
                    {
                        sb.AppendLine("No swap required");
                    }
                    else
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                if (originalRubikCube[row, col] == rubikCube[i, j])
                                {
                                    sb.AppendLine($"Swap ({row}, {col}) with ({i}, {j})");
                                    tempRubikCube[0, 0] = rubikCube[row, col];
                                    rubikCube[row, col] = originalRubikCube[row, col];
                                    rubikCube[i, j] = tempRubikCube[0, 0];
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }

        public static void GetShuffledSide(int[,] rubikCube, int[] currentSide, int rowOrCol, string direction)
        {
            for (int i = 0; i < currentSide.Length; i++)
            {
                if (direction == "up" || direction == "down")
                {
                    rubikCube[i, rowOrCol] = currentSide[i];
                }
                else
                {
                    rubikCube[rowOrCol, i] = currentSide[i];
                }
            }
        }

        public static void ShuffleCurrentSide(int[] currentSide, int moves, string direction)
        {
            if (direction == "down" || direction == "right")
            {
                Array.Reverse(currentSide);
            }

            for (int move = 0; move < moves % currentSide.Length; move++)
            {
                int currentNumber = currentSide[0];
                for (int i = 1; i < currentSide.Length; i++)
                {
                    currentSide[i - 1] = currentSide[i];
                }

                currentSide[currentSide.Length - 1] = currentNumber;
            }

            if (direction == "down" || direction == "right")
            {
                Array.Reverse(currentSide);
            }
        }

        public static void FillCurrentSide(int[] currentSide, int[,] rubikCube, int rowOrCol, string direction)
        {
            for (int i = 0; i < currentSide.Length; i++)
            {
                if (direction == "up" || direction == "down")
                {
                    currentSide[i] = rubikCube[i, rowOrCol];
                }
                else
                {
                    currentSide[i] = rubikCube[rowOrCol, i];
                }
            }
        }
    }
}

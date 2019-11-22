namespace _11._Parking_System
{
    using System;
    using System.Linq;
    using System.Text;

    public class ParkingSystem
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int[][] parkingLot = new int[dimensions[0]][];
            while (input != "stop")
            {
                int[] commands = input.Split().Select(int.Parse).ToArray();
                int entryRow = commands[0];
                int desiredRow = commands[1];
                int desiredCol = commands[2];
                int counter = Math.Abs(entryRow - desiredRow) + 1;
                bool isFull = true;
                if (parkingLot[desiredRow] == null)
                {
                    parkingLot[desiredRow] = new int[dimensions[1]];
                }

                if (parkingLot[desiredRow][desiredCol] == 0)
                {
                    parkingLot[desiredRow][desiredCol] = 1;
                    sb.AppendLine((counter + desiredCol).ToString());
                }
                else if (parkingLot[desiredRow][desiredCol] != 0)
                {
                    for (int col = 1; col < parkingLot[desiredRow].Length; col++)
                    {
                        if (desiredCol - col > 0 && parkingLot[desiredRow][desiredCol - col] == 0)
                        {
                            sb.AppendLine((counter + desiredCol - col).ToString());
                            parkingLot[desiredRow][desiredCol - col] = 1;
                            isFull = false;
                            break;
                        }

                        if (desiredCol + col < parkingLot[desiredRow].Length &&
                                 parkingLot[desiredRow][desiredCol + col] == 0)
                        {
                            sb.AppendLine((counter + desiredCol + col).ToString());
                            parkingLot[desiredRow][desiredCol + col] = 1;
                            isFull = false;
                            break;
                        }
                    }

                    if (isFull)
                    {
                        sb.AppendLine($"Row {desiredRow} full");
                    }
                }

                input = Console.ReadLine();
            }

            Console.Write(sb);
        }
    }
}

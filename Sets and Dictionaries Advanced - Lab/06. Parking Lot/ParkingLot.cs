namespace _06._Parking_Lot
{
    using System;
    using System.Collections.Generic;

    public class ParkingLot
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            HashSet<string> parkingLot = new HashSet<string>();
            while (input != "END")
            {
                string[] tokens = input.Split($", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string carNumber = tokens[1];
                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}

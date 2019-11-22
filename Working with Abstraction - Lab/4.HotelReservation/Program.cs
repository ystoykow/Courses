using System;

namespace _4.HotelReservation
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            var priceCalc = new PriceCalculator(input);
            Console.WriteLine($"{priceCalc.GetPrice():f2}");
        }
    }
}

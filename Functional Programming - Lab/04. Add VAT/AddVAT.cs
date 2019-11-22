namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class AddVAT
    {
        public static void Main()
        {
            Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x=>x*1.2)
                .ToList()
                .ForEach(x=>Console.WriteLine($"{x:f2}"));
        }
    }
}

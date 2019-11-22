namespace Ferrari
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string driver = Console.ReadLine();
            Ferrari current = new Ferrari(driver);
            Console.WriteLine(current);
        }
    }
}

namespace Telephony
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Smartphone phone = new Smartphone();
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] webSites = Console.ReadLine().Split(" ");
            for (int i = 0; i <phoneNumbers.Length; i++)
            {
                Console.WriteLine(phone.Call(phoneNumbers[i]));
            }

            for (int i = 0; i < webSites.Length; i++)
            {
                Console.WriteLine(phone.Browse(webSites[i]));
            }
        }
    }
}

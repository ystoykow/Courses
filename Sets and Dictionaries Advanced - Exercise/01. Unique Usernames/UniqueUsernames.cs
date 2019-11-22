namespace _01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsernames
    {
        public static void Main()
        {
            int recordsCount = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsernames = new HashSet<string>();
            for (int i = 0; i < recordsCount; i++)
            {
                string input = Console.ReadLine();
                uniqueUsernames.Add(input);
            }

            foreach (var user in uniqueUsernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}

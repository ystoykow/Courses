namespace _11._The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ThePartyReservationFilterModule
    {
        public static void Main()
        {
            List<string> users = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> filters = new List<string>();
            string input = Console.ReadLine();
            while (input != "Print")
            {
                string[] tokens = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string criteria = tokens[1];
                string parameters = tokens[2];

                if (command == "Add filter")
                {
                    filters.Add($"{criteria};{parameters}");
                }
                else
                {
                    filters.Remove($"{criteria};{parameters}");
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] currentFilterInfo = filter.Split(";").ToArray();
                string criteria = currentFilterInfo[0];
                string parameters = currentFilterInfo[1];
                Func<string, bool> currentFunc = GetFunc(criteria, parameters);

                users = users.Where(x=>!currentFunc(x)).ToList();
            }

            Console.WriteLine(string.Join(" ",users));
        }

        public static Func<string, bool> GetFunc(string criteria,string parameters)
        {

            if (criteria == "Starts with")
            {
                return x => x.StartsWith(parameters);
            }
            else if (criteria == "Length")
            {
                return x => x.Length == int.Parse(parameters);
            }
            else if (criteria == "Ends with")
            {
                return x=>x.EndsWith(parameters);
            }
            else if (criteria == "Contains")
            {
                return x => x.Contains(parameters);
            }

            return null;
        }
    }
}

namespace P04_Hospital
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Hospital hospital = new Hospital();
            
            string commands = Console.ReadLine();
            while (commands != "Output")
            {
                string[] tokens = commands.Split();
                hospital.Add(tokens);
               
                commands = Console.ReadLine();
            }

            commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] args = commands.Split();
                Console.WriteLine(hospital.GetInfo(args));
                
                commands = Console.ReadLine();
            }
        }
    }
}

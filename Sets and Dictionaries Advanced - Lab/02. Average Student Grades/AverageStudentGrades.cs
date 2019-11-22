namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            int recordsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < recordsCount; i++)
            {
                string[] kvp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = kvp[0];
                double grade = double.Parse(kvp[1]);
                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double>());
                }

                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                Console.Write($"{kvp.Key} -> ");
                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}

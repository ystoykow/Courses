namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Filter
    {
        public string GetCars(string command, CarCatalog carCatalog)
        {
            StringBuilder sb = new StringBuilder();
            if (command == "fragile")
            {
                List<string> fragile = carCatalog.GetCars()
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                sb.AppendLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = carCatalog.GetCars()
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                sb.AppendLine(string.Join(Environment.NewLine, flamable));
            }

            return sb.ToString().Trim();
        }
    }
}

using System.Linq;

namespace Telephony
{
    public class Smartphone : IBrowse, ICall
    {
        private string Model { get; }

        public string Call(string numberAsText)
        {
            if (numberAsText.All(char.IsDigit))
            {
                return $"Calling... {numberAsText}";
            }

            return $"Invalid number!";
        }

        public string Browse(string URL)
        {
            if (!URL.Any(char.IsDigit))
            {
                return $"Browsing: {URL}!";
            }

            return $"Invalid URL!";
        }
    }
}

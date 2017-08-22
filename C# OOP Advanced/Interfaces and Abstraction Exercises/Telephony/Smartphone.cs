using System;

namespace Telephony
{
    internal class Smartphone : ICall, IBrowse
    {
        public string Browsing(string site)
        {
            foreach (var symbol in site)
            {
                if (char.IsNumber(symbol))
                {
                    throw new ArgumentException("Invalid URL!");
                }
            }

            return "Browsing: " + site;
        }

        public string Calling(string number)
        {
            foreach (var symbol in number)
            {
                if (!char.IsNumber(symbol))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }

            return "Calling... " + number;
        }
    }
}

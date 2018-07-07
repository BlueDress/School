using System.Globalization;

namespace Ch22P07
{
    public static class StringExtensions
    {
        public static string CapitalizeWords(this string str)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(str);
        }
    }
}

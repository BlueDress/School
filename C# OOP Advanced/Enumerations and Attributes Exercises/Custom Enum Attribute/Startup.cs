using System;

namespace Custom_Enum_Attribute
{
    public class Startup
    {
        public static void Main()
        {
            var category = Console.ReadLine();
            var type = category == "Rank" ? typeof(CardRank) : typeof(CardSuit);
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0].ToString());
        }
    }
}

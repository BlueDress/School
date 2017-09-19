using System;

namespace Debit_Card_Number
{
    public class Startup
    {
        public static void Main()
        {
            var firstInteger = int.Parse(Console.ReadLine());
            var secondInteger = int.Parse(Console.ReadLine());
            var thirdInteger = int.Parse(Console.ReadLine());
            var fourthInteger = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstInteger:d4} {secondInteger:d4} {thirdInteger:d4} {fourthInteger:d4}");
        }
    }
}

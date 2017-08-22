using System;

namespace Telephony
{
    internal class Engine
    {
        internal void Run()
        {
            var numbers = Console.ReadLine().Split();
            var sites = Console.ReadLine().Split();

            var phone = new Smartphone();

            foreach (var number in numbers)
            {
                try
                {
                    Console.WriteLine(phone.Calling(number));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var site in sites)
            {
                try
                {
                    Console.WriteLine(phone.Browsing(site));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

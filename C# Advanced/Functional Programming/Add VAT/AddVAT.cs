using System;
using System.Linq;

namespace Add_VAT
{
    public class AddVAT
    {
        public static void Main()
        {
            Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x * 1.2).ToList().ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}

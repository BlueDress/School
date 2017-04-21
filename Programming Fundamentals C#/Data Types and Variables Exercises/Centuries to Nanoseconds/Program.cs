using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte c = byte.Parse(Console.ReadLine());
            short y = (short)(c * 100);
            int d = (int)(y * 365.2422);
            long h = d * 24;
            long m = h * 60;
            long s = m * 60;
            BigInteger mil = s * 1000;
            BigInteger mic = mil * 1000;
            BigInteger n = mil * 1000;

            Console.WriteLine($"{c} centuries = {y} years = {d} days = {h} hours = {m} minutes = {s} seconds = {mil} milliseconds = {mic} microseconds = {n} nanoseconds");
        }
    }
}

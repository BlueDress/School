using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var ft = double.Parse(Console.ReadLine());
            var ff = double.Parse(Console.ReadLine());
            var ut = double.Parse(Console.ReadLine());

            var ftime = n * ft;
            var good = Math.Ceiling(ff / 100 * n);
            var utime = good * ut;
            var result = ftime + utime;
            
            TimeSpan res = TimeSpan.FromSeconds(result);
            Console.WriteLine(res.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}

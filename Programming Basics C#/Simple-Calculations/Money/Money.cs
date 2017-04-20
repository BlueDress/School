using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на биткойните ");
            var bccount = int.Parse(Console.ReadLine());

            Console.Write("Въведете броя на китайските юани ");
            var CNY = double.Parse(Console.ReadLine());

            Console.Write("Въведете комисионната на обменното бюро ");
            var commission = double.Parse(Console.ReadLine());

            var EUR = (((bccount * 1168) + ((CNY * 0.15) * 1.76)) / 1.95) - ((commission * ((bccount * 1168) + ((CNY * 0.15) * 1.76)) / 1.95) / 100);
            Console.WriteLine($"За {bccount} биткойни и {CNY} китайски юана, при комисионна {commission}%, ще получите {EUR} евра");
        }
    }
}

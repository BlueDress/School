using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число ");
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            bool check = true;

            for (int i = 1111; i <= 9999; i++)
            {
                count = i;
                check = true;
                do
                {
                    if (count % 10 != 0 && n % (count % 10) == 0)
                        count = count / 10;
                    else
                    {
                        check = false;
                        break;                     
                    }
                } while (count > 0);
                if (check) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

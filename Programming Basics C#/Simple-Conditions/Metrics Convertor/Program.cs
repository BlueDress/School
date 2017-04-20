using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете разстояние за пресмятане ");
            var dist = double.Parse(Console.ReadLine());

            Console.Write("Изберете мерна единица ");
            var inmetrics = Console.ReadLine();

            Console.Write("В каква мерна единица искате да преизчислите избраното разстояние ");
            var outnmetrics = Console.ReadLine();

            var tempdist = 0.0;

            if (inmetrics == "mm")
            {
                tempdist = dist / 1000;
            }
            else if (inmetrics == "cm")
            {
                tempdist = dist / 100;
            }
            else if (inmetrics == "mi")
            {
                tempdist = dist / 0.000621371192;
            }
            else if (inmetrics == "in")
            {
                tempdist = dist / 39.3700787;
            }
            else if (inmetrics == "km")
            {
                tempdist = dist / 0.001;
            }
            else if (inmetrics == "ft")
            {
                tempdist = dist / 3.2808399;
            }
            else if (inmetrics == "yd")
            {
                tempdist = dist / 1.0936133;
            }
            else 
            {
                tempdist = dist;
            }
            
            if (outnmetrics == "mm")
            {
                tempdist = tempdist * 1000;
            }
            else if (outnmetrics == "cm")
            {
                tempdist = tempdist * 100;
            }
            else if (outnmetrics == "mi")
            {
                tempdist = tempdist * 0.000621371192;
            }
            else if (outnmetrics == "in")
            {
                tempdist = tempdist * 39.3700787;
            }
            else if (outnmetrics == "km")
            {
                tempdist = tempdist * 0.001;
            }
            else if (outnmetrics == "ft")
            {
                tempdist = tempdist * 3.2808399;
            }
            else if (outnmetrics == "yd")
            {
                tempdist = tempdist * 1.0936133;
            }
            else
            {
                tempdist = dist;
            }
            

            Console.WriteLine($"{dist} {inmetrics} са равни на {tempdist} {outnmetrics}");
        }
    }
}

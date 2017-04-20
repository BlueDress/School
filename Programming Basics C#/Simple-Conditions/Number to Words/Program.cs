using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число в интервала от 0 до 100 ");
            var num = int.Parse(Console.ReadLine());

            int a = num / 10;
            int b = num % 10;

            string tens = "";
            string units = "";
            if ((num < 0) || (num > 100))
            {
                Console.WriteLine("Числото не е в интервала от 0 до 100");
            }
            else if (num <= 100)
            {
                if ((a != 1) && (a != 0))
                {
                    if (a == 2) tens = "Двадесет ";
                    if (a == 3) tens = "Тридесет ";
                    if (a == 4) tens = "Четиридесет ";
                    if (a == 5) tens = "Петдесет ";
                    if (a == 6) tens = "Шесдесет ";
                    if (a == 7) tens = "Седемдесет ";
                    if (a == 8) tens = "Осемдесет ";
                    if (a == 9) tens = "Деведесет ";
                    if (a == 10) tens = "Сто ";
                    if (b == 0) units = "";
                    if (b == 1) units = "и Едно ";
                    if (b == 2) units = "и Две ";
                    if (b == 3) units = "и Три ";
                    if (b == 4) units = "и Четири ";
                    if (b == 5) units = "и Пет ";
                    if (b == 6) units = "и Шест ";
                    if (b == 7) units = "и Седем ";
                    if (b == 8) units = "и Осем ";
                    if (b == 9) units = "и Девет ";
                    Console.WriteLine($"{tens}{units}");
                }
                else if (a == 0)
                {
                    if (b == 0) units = "Нула ";
                    if (b == 1) units = "Едно ";
                    if (b == 2) units = "Две ";
                    if (b == 3) units = "Три ";
                    if (b == 4) units = "Четири ";
                    if (b == 5) units = "Пет ";
                    if (b == 6) units = "Шест ";
                    if (b == 7) units = "Седем ";
                    if (b == 8) units = "Осем ";
                    if (b == 9) units = "Девет ";
                    Console.WriteLine($"{units}");
                }
                else if (a == 1)
                {
                    if (b == 0) Console.WriteLine("Десет");
                    if (b == 1) Console.WriteLine("Единадесет");
                    if (b == 2) Console.WriteLine("Дванадесет");
                    if (b == 3) Console.WriteLine("Тринадесет");
                    if (b == 4) Console.WriteLine("Четиринадесет");
                    if (b == 5) Console.WriteLine("Петнадесет");
                    if (b == 6) Console.WriteLine("Шестнадесет");
                    if (b == 7) Console.WriteLine("Седемнадесет");
                    if (b == 8) Console.WriteLine("Осемнадесет");
                    if (b == 9) Console.WriteLine("Деветнадесет");
                }
            }
        }
    }
}

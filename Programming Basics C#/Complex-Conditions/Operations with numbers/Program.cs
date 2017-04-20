using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете цяло число ");
            var n1 = int.Parse(Console.ReadLine());

            Console.Write("Въведете цяло число ");
            var n2 = int.Parse(Console.ReadLine());

            Console.Write("Въведете оператор ");
            var oper = Console.ReadLine();

            var result = 0.0;
            var eo = "";

            if (oper == "+" || oper == "-" || oper == "*")
            {
                if (oper == "+")
                {
                    result = n1 + n2;
                }
                else if (oper == "-")
                {
                    result = n1 - n2;
                }
                else
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    eo = "even";
                }
                else
                {
                    eo = "odd";
                }
                Console.WriteLine($"{n1} {oper} {n2} = {result} - {eo}");
            }
            else
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    if (oper == "/")
                    {
                        double n3 = n1;
                        double n4 = n2;
                        result = n3 / n4;
                        Console.WriteLine($"{n1} {oper} {n2} = {result:f2}");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                }
            }
        }
    }
}

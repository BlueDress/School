using System;

namespace Dependency_Inversion
{
    public class Startup
    {
        public static void Main()
        {
            var calculator = new PrimitiveCalculator();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                var commandArgs = input.Split();
                var command = commandArgs[0];

                if (command.Equals("mode"))
                {
                    calculator.changeStrategy(commandArgs[1][0]);
                }
                else
                {
                    var firstOperand = int.Parse(command);
                    var secondOperand = int.Parse(commandArgs[1]);

                    Console.WriteLine(calculator.performCalculation(firstOperand, secondOperand));
                }
            }
        }
    }
}

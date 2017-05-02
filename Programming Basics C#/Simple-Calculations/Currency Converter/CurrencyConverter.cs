using System;

namespace Currency_Converter
{
    class CurrencyConverter
    {
        static void Main()
        {
            var amount = double.Parse(Console.ReadLine());
            string entryCurrency = Console.ReadLine();
            string outCurrency = Console.ReadLine();

            double temp = 0;
            if (entryCurrency == "USD")
            {
                temp = amount * 1.79549;
            }
            else if (entryCurrency == "EUR")
            {
                temp = amount * 1.95583;
            }
            else if (entryCurrency == "GBP")
            {
                temp = amount * 2.53405;
            }
            else
            {
                temp = amount;
            }

            double result = 0;
            if (outCurrency == "USD")
            {
                result = temp / 1.79549;
            }
            else if (outCurrency == "EUR")
            {
                result = temp / 1.95583;
            }
            else if (outCurrency == "GBP")
            {
                result = temp / 2.53405;
            }
            else
            {
                result = temp;
            }
            Console.WriteLine($"{Math.Round(result, 2)}, {outCurrency}");
        }
    }
}

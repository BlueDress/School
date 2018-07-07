using System;

namespace Ch08P11
{
    public class Startup
    {
        public static void Main()
        {
            string numberInRoman = Console.ReadLine();

            int[] numericalValues = new int[numberInRoman.Length];

            for (int i = 0; i < numberInRoman.Length; i++)
            {
                switch (numberInRoman[i].ToString().ToLower())
                {
                    case "i":
                        numericalValues[i] = 1;
                        break;
                    case "v":
                        numericalValues[i] = 5;
                        break;
                    case "x":
                        numericalValues[i] = 10;
                        break;
                    case "l":
                        numericalValues[i] = 50;
                        break;
                    case "c":
                        numericalValues[i] = 100;
                        break;
                    case "d":
                        numericalValues[i] = 500;
                        break;
                    case "m":
                        numericalValues[i] = 1000;
                        break;
                }
            }

            int numberInArabic = 0;

            for (int i = 0; i < numericalValues.Length; i++)
            {
                if (i == numericalValues.Length - 1 || numericalValues[i] >= numericalValues[i + 1])
                {
                    numberInArabic += numericalValues[i];
                }
                else
                {
                    numberInArabic += (numericalValues[i + 1] - numericalValues[i]);
                    i++;
                }
            }

            Console.WriteLine(numberInArabic);
        }
    }
}

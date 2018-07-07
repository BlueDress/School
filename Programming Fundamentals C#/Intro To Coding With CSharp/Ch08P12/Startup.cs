using System;

namespace Ch08P12
{
    public class Startup
    {
        public static void Main()
        {
            int numberInArabic = int.Parse(Console.ReadLine());

            if (numberInArabic <= 0 || 4000 <= numberInArabic)
            {
                throw new Exception("Number must be between 1 and 3999 both inclusive");
            }

            int thousands = numberInArabic / 1000;
            int hundreds = (numberInArabic % 1000) / 100;
            int tens = (numberInArabic % 100) / 10;
            int singles = numberInArabic  % 10;

            string numberInRoman = string.Empty;

            switch (thousands)
            {
                case 1:
                    numberInRoman += "M";
                    break;
                case 2:
                    numberInRoman += "MM";
                    break;
                case 3:
                    numberInRoman += "MMM";
                    break;
                default:
                    break;
            }

            switch (hundreds)
            {
                case 1:
                    numberInRoman += "C";
                    break;
                case 2:
                    numberInRoman += "CC";
                    break;
                case 3:
                    numberInRoman += "CCC";
                    break;
                case 4:
                    numberInRoman += "CD";
                    break;
                case 5:
                    numberInRoman += "D";
                    break;
                case 6:
                    numberInRoman += "DC";
                    break;
                case 7:
                    numberInRoman += "DCC";
                    break;
                case 8:
                    numberInRoman += "DCCC";
                    break;
                case 9:
                    numberInRoman += "CM";
                    break;
                default:
                    break;
            }

            switch (tens)
            {
                case 1:
                    numberInRoman += "X";
                    break;
                case 2:
                    numberInRoman += "XX";
                    break;
                case 3:
                    numberInRoman += "XXX";
                    break;
                case 4:
                    numberInRoman += "XL";
                    break;
                case 5:
                    numberInRoman += "L";
                    break;
                case 6:
                    numberInRoman += "LX";
                    break;
                case 7:
                    numberInRoman += "LXX";
                    break;
                case 8:
                    numberInRoman += "LXXX";
                    break;
                case 9:
                    numberInRoman += "XC";
                    break;
                default:
                    break;
            }

            switch (singles)
            {
                case 1:
                    numberInRoman += "I";
                    break;
                case 2:
                    numberInRoman += "II";
                    break;
                case 3:
                    numberInRoman += "III";
                    break;
                case 4:
                    numberInRoman += "IV";
                    break;
                case 5:
                    numberInRoman += "V";
                    break;
                case 6:
                    numberInRoman += "VI";
                    break;
                case 7:
                    numberInRoman += "VII";
                    break;
                case 8:
                    numberInRoman += "VIII";
                    break;
                case 9:
                    numberInRoman += "IX";
                    break;
                default:
                    break;
            }

            Console.WriteLine(numberInRoman);
        }
    }
}

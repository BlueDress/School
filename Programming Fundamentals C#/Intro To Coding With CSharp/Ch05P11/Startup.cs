using System;

namespace Ch05P11
{
    public class Startup
    {
        public static void Main()
        {
            for (int number = 0; number < 1000; number++)
            {
                string numberAsWords = string.Empty;

                int hundreds = number / 100;
                string hundredsAsWords = string.Empty;

                switch (hundreds)
                {
                    case 1:
                        hundredsAsWords = "Сто";
                        break;
                    case 2:
                        hundredsAsWords = "Двеста";
                        break;
                    case 3:
                        hundredsAsWords = "Триста";
                        break;
                    case 4:
                        hundredsAsWords = "Четиристотин";
                        break;
                    case 5:
                        hundredsAsWords = "Петстотин";
                        break;
                    case 6:
                        hundredsAsWords = "Шестстотин";
                        break;
                    case 7:
                        hundredsAsWords = "Седемстотин";
                        break;
                    case 8:
                        hundredsAsWords = "Осемстотин";
                        break;
                    case 9:
                        hundredsAsWords = "Деветстотин";
                        break;
                    default:
                        break;
                }

                int tens = (number % 100) / 10;
                string tensAsWords = string.Empty;

                int singles = number % 10;
                string singlesAsWord = string.Empty;

                switch (tens)
                {
                    case 1:
                        switch (singles)
                        {
                            case 0:
                                tensAsWords = "Десет";
                                break;
                            case 1:
                                tensAsWords = "Единадесет";
                                break;
                            case 2:
                                tensAsWords = "Дванадесет";
                                break;
                            case 3:
                                tensAsWords = "Тринадесет";
                                break;
                            case 4:
                                tensAsWords = "Четиринадесет";
                                break;
                            case 5:
                                tensAsWords = "Петнадесет";
                                break;
                            case 6:
                                tensAsWords = "Шестнадесет";
                                break;
                            case 7:
                                tensAsWords = "Седемнадесет";
                                break;
                            case 8:
                                tensAsWords = "Осемнадесет";
                                break;
                            case 9:
                                tensAsWords = "Деветнадесет";
                                break;
                        }
                        break;
                    case 2:
                        tensAsWords = "Двадесет";
                        break;
                    case 3:
                        tensAsWords = "Тридесет";
                        break;
                    case 4:
                        tensAsWords = "Четиридесет";
                        break;
                    case 5:
                        tensAsWords = "Петдесет";
                        break;
                    case 6:
                        tensAsWords = "Шестдесет";
                        break;
                    case 7:
                        tensAsWords = "Седемдесет";
                        break;
                    case 8:
                        tensAsWords = "Осемдесет";
                        break;
                    case 9:
                        tensAsWords = "Деведесет";
                        break;
                    default:
                        break;
                }

                switch (singles)
                {
                    case 1:
                        singlesAsWord = "Едно";
                        break;
                    case 2:
                        singlesAsWord = "Две";
                        break;
                    case 3:
                        singlesAsWord = "Три";
                        break;
                    case 4:
                        singlesAsWord = "Четири";
                        break;
                    case 5:
                        singlesAsWord = "Пет";
                        break;
                    case 6:
                        singlesAsWord = "Шест";
                        break;
                    case 7:
                        singlesAsWord = "Седем";
                        break;
                    case 8:
                        singlesAsWord = "Осем";
                        break;
                    case 9:
                        singlesAsWord = "Девет";
                        break;
                    default:
                        break;
                }

                if (hundreds == 0 && tens == 0)
                {
                    numberAsWords = singles == 0 ? "Нула" : singlesAsWord;
                }
                else if (tens == 1)
                {
                    numberAsWords = hundreds == 0 ? tensAsWords : hundredsAsWords + " и " + tensAsWords;
                }
                else if (hundreds == 0)
                {
                    numberAsWords = singles == 0 ? tensAsWords : tensAsWords + " и " + singlesAsWord;
                }
                else
                {
                    if (singles == 0 && tens == 0)
                    {
                        numberAsWords = hundredsAsWords;
                    }
                    else
                    {
                        if (singles == 0)
                        {
                            numberAsWords = hundredsAsWords + " и " + tensAsWords;
                        }
                        else
                        {
                            numberAsWords = tens == 0 ? hundredsAsWords + " и " + singlesAsWord : hundredsAsWords + " " + tensAsWords + " и " + singlesAsWord;
                        }
                    }
                }

                Console.WriteLine(numberAsWords);
            }
        }
    }
}

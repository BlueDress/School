using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var patterns = new string[] { @"(\${6,})", @"(\#{6,})", @"(\@{6,})", @"(\^{6,})" };

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftHalf = ticket.Substring(0, 10);
                    var rightHalf = ticket.Substring(10, 10);

                    var isMatch = false;

                    for (int i = 0; i < 4; i++)
                    {
                        var regex = new Regex(patterns[i]);

                        var leftMatch = regex.Match(leftHalf).ToString();
                        var rightMatch = regex.Match(rightHalf).ToString();

                        if (leftMatch.Length > 0 && rightMatch.Length > 0)
                        {
                            if (leftMatch.Equals(rightMatch))
                            {
                                if (leftMatch.Length != 10)
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {leftMatch.Length}{leftMatch.First()}");
                                    isMatch = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {leftMatch.Length}{leftMatch.First()} Jackpot!");
                                    isMatch = true;
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}{leftMatch.First()}");
                                isMatch = true;
                                break;
                            }
                        }

                    }

                    if (isMatch == false)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}

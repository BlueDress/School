using System;
using System.Linq;

namespace Trophon_the_Grumpy_Cat
{
    public class TrophonTheGrumpyCat
    {
        public static void Main()
        {
            var priceRatings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var entryPoint = int.Parse(Console.ReadLine());
            var typeOfItems = Console.ReadLine();
            var typeOfPriceRatings = Console.ReadLine();

            var leftSum = 0;
            var rightSum = 0;

            for (int i = entryPoint - 1; i >= 0; i--)
            {
                if (typeOfItems.Equals("cheap"))
                {
                    if (typeOfPriceRatings.Equals("positive"))
                    {
                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            leftSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("negative"))
                    {
                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] < 0)
                        {
                            leftSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("all"))
                    {
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            leftSum += priceRatings[i];
                        }
                    }
                }
                else if (typeOfItems.Equals("expensive"))
                {
                    if (typeOfPriceRatings.Equals("positive"))
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            leftSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("negative"))
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] < 0)
                        {
                            leftSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("all"))
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            leftSum += priceRatings[i];
                        }
                    }
                }
            }

            for (int i = entryPoint + 1; i < priceRatings.Length; i++)
            {
                if (typeOfItems.Equals("cheap"))
                {
                    if (typeOfPriceRatings.Equals("positive"))
                    {
                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            rightSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("negative"))
                    {
                        if (priceRatings[i] < priceRatings[entryPoint] && priceRatings[i] < 0)
                        {
                            rightSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("all"))
                    {
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            rightSum += priceRatings[i];
                        }
                    }
                }
                else if (typeOfItems.Equals("expensive"))
                {
                    if (typeOfPriceRatings.Equals("positive"))
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] > 0)
                        {
                            rightSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("negative"))
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint] && priceRatings[i] < 0)
                        {
                            rightSum += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRatings.Equals("all"))
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            rightSum += priceRatings[i];
                        }
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}

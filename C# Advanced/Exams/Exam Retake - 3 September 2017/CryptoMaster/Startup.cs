using System;
using System.Linq;

namespace CryptoMaster
{
    public class Startup
    {
        public static void Main()
        {
            var lockerSequence = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var jumpingStep = 0;
            var longestSequence = 1;

            for (int i = 0; i < lockerSequence.Count; i++)
            {
                jumpingStep++;

                if (lockerSequence[i] < lockerSequence[(i + jumpingStep) % lockerSequence.Count])
                {
                    var currentSequence = 2;
                    var index = jumpingStep;

                    for (int j = 0; j < lockerSequence.Count - 1; j++)
                    {
                        if (lockerSequence[(i + index) % lockerSequence.Count] < lockerSequence[(i + index + jumpingStep) % lockerSequence.Count])
                        {
                            index += jumpingStep;
                            currentSequence++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }

                }

                if (jumpingStep == lockerSequence.Count - 1)
                {
                    jumpingStep = 0;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine(longestSequence);
        }
    }
}

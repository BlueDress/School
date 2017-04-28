using System;
namespace Largest_Common_End
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] FirstArray = Console.ReadLine().Split();
            string[] SecondArray = Console.ReadLine().Split();

            var frontToBack = 0;

            for (int i = 0; i < Math.Min(FirstArray.Length, SecondArray.Length); i++)
            {
                if (FirstArray[i] == SecondArray[i])
                {
                    frontToBack++;
                }
                else
                {
                    break;
                }
            }

            var backToFront = 0;

            for (int i = 0; i < Math.Min(FirstArray.Length, SecondArray.Length) - 1; i++)
            {
                if (FirstArray[FirstArray.Length - 1 - i] == SecondArray[SecondArray.Length - 1 - i])
                {
                    backToFront++;
                }
                else
                {
                    break;
                }
            }

            if (frontToBack >= backToFront)
            {
                Console.WriteLine(frontToBack);
            }
            else if (frontToBack < backToFront)
            {
                Console.WriteLine(backToFront);
            }
        }
    }
}

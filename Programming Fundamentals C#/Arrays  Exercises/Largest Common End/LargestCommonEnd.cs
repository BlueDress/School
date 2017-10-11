using System;
namespace Largest_Common_End
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] FirstArray = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] SecondArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var frontToBack = 0;

            for (int i = 0; i < Math.Min(FirstArray.Length, SecondArray.Length); i++)
            {
                if (FirstArray[i].Equals(SecondArray[i]))
                {
                    frontToBack++;
                }
                else
                {
                    break;
                }
            }

            var backToFront = 0;

            for (int i = 0; i < Math.Min(FirstArray.Length, SecondArray.Length); i++)
            {
                if (FirstArray[FirstArray.Length - 1 - i].Equals(SecondArray[SecondArray.Length - 1 - i]))
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


using System;

namespace Random_List
{
    public class RndList
    {
        public static void Main()
        {
            var randomList = new RandomList();
            var rnd = new Random();

            for (int i = 0; i < (Math.Abs(rnd.Next()) % 99); i++)
            {
                randomList.Add(i + rnd.Next());
            }

            Console.WriteLine(randomList.RandomString(randomList));
        }
    }
}

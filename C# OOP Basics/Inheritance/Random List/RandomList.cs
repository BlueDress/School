
using System;
using System.Collections;

namespace Random_List
{
    public class RandomList : ArrayList
    {
        //private Random rnd;
        //
        //public RandomList()
        //{
        //    this.rnd = new Random();
        //}
        //
        //public string RandomString()
        //{
        //    return string.Empty;
        //}

        public string RandomString(RandomList randomList)
        {
            var rnd = new Random();
            var number = rnd.Next();
            var result = randomList[Math.Abs(number) % randomList.Count];
            randomList.RemoveAt(Math.Abs(number) % randomList.Count);
            return result.ToString();
        }
    }
}

using System;
using System.Linq;

namespace Hornet_Assault
{
    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(int.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < beehives.Count; i++)
            {
                var hornetsPower = hornets.Sum();

                if (beehives[i] < hornetsPower)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] = beehives[i] - hornetsPower;
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Anonymous_Downsite
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfSites = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());

            var totalLoss = 0m;
            var affectedSites = new List<string>();

            for (int i = 0; i < numberOfSites; i++)
            {
                var args = Console.ReadLine().Split();
                var siteName = args[0];
                affectedSites.Add(siteName);

                var siteVisits = long.Parse(args[1]);
                var siteCommercialPricePerVisit = decimal.Parse(args[2]);

                var siteLoss = siteVisits * siteCommercialPricePerVisit;

                totalLoss += siteLoss;
            }

            foreach (var site in affectedSites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");

            BigInteger securityToken = 1;

            for (int i = 0; i < numberOfSites; i++)
            {
                securityToken *= securityKey;
            }

            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}

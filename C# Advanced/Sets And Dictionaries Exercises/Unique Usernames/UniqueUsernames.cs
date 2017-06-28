using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            var usernames = new HashSet<string>();

            var numberOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}

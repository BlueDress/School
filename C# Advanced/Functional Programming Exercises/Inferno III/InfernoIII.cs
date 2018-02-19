using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno_III
{
    public class InfernoIII
    {
        public static void Main()
        {
            var gems = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            var gemsStatus = new bool[gems.Length];

            for (int i = 0; i < gemsStatus.Length; i++)
            {
                gemsStatus[i] = true;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Forge"))
                {
                    break;
                }
                else
                {
                    gemsStatus = GemsPowersFilterModule(gems, gemsStatus, input);
                }
            }

            var gemsToForge = new List<long>();

            for (int i = 0; i < gems.Length; i++)
            {
                if (gemsStatus[i])
                {
                    gemsToForge.Add(gems[i]);
                }
            }

            Console.WriteLine(string.Join(" ", gemsToForge));
        }

        private static bool[] GemsPowersFilterModule(long[] gems, bool[] gemsStatus, string input)
        {
            var tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "Exclude":
                    gemsStatus = ExcludeGems(gems, gemsStatus, tokens[1], tokens[2]);
                    break;
                case "Reverse":
                    gemsStatus = ReverseExclusions(gems, gemsStatus, tokens[1], tokens[2]);
                    break;
            }

            return gemsStatus;
        }

        private static bool[] ReverseExclusions(long[] gems, bool[] gemsStatus, string filterType, string filterParameter)
        {
            var value = long.Parse(filterParameter);

            switch (filterType)
            {
                case "Sum Left":
                    if (gems[0] + 0 == value)
                    {
                        gemsStatus[0] = true;
                    }

                    for (int i = 1; i < gems.Length; i++)
                    {
                        if (gems[i] + gems[i - 1] == value)
                        {
                            gemsStatus[i] = true;
                        }
                    }
                    break;
                case "Sum Right":
                    if (gems[gems.Length - 1] + 0 == value)
                    {
                        gemsStatus[gems.Length - 1] = true;
                    }

                    for (int i = 0; i < gems.Length - 1; i++)
                    {
                        if (gems[i] + gems[i + 1] == value)
                        {
                            gemsStatus[i] = true;
                        }
                    }
                    break;
                case "Sum Left Right":
                    if (gems.Length > 1)
                    {
                        if (gems[0] + gems[1] == value)
                        {
                            gemsStatus[0] = true;
                        }

                        if (gems[gems.Length - 1] + gems[gems.Length - 2] == value)
                        {
                            gemsStatus[gems.Length - 1] = true;
                        }

                        for (int i = 1; i < gems.Length - 1; i++)
                        {
                            if (gems[i] + gems[i + 1] + gems[i - 1] == value)
                            {
                                gemsStatus[i] = true;
                            }
                        }
                    }
                    else
                    {
                        if (gems[0] == value)
                        {
                            gemsStatus[0] = true;
                        }
                    }
                    break;
            }
            return gemsStatus;
        }

        private static bool[] ExcludeGems(long[] gems, bool[] gemsStatus, string filterType, string filterParameter)
        {
            var value = long.Parse(filterParameter);

            switch (filterType)
            {
                case "Sum Left":
                    if (gems[0] + 0 == value)
                    {
                        gemsStatus[0] = false;
                    }

                    for (int i = 1; i < gems.Length; i++)
                    {
                        if (gems[i] + gems[i - 1] == value)
                        {
                            gemsStatus[i] = false;
                        }
                    }
                    break;
                case "Sum Right":
                    if (gems[gems.Length - 1] + 0 == value)
                    {
                        gemsStatus[gems.Length - 1] = false;
                    }

                    for (int i = 0; i < gems.Length - 1; i++)
                    {
                        if (gems[i] + gems[i + 1] == value)
                        {
                            gemsStatus[i] = false;
                        }
                    }
                    break;
                case "Sum Left Right":
                    if (gems.Length > 1)
                    {
                        if (gems[0] + gems[1] == value)
                        {
                            gemsStatus[0] = false;
                        }

                        if (gems[gems.Length - 1] + gems[gems.Length - 2] == value)
                        {
                            gemsStatus[gems.Length - 1] = false;
                        }

                        for (int i = 1; i < gems.Length - 1; i++)
                        {
                            if (gems[i] + gems[i + 1] + gems[i - 1] == value)
                            {
                                gemsStatus[i] = false;
                            }
                        }
                    }
                    else
                    {
                        if (gems[0] == value)
                        {
                            gemsStatus[0] = false;
                        }
                    }
                    break;
            }
            return gemsStatus;
        }
    }
}

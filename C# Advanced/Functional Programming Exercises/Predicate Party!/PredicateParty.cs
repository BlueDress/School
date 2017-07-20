using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    public class PredicateParty
    {
        public static void Main()
        {
            var guestsList = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Party!"))
                {
                    break;
                }
                else
                {
                    guestsList = GuestListModification(guestsList, input);
                }

            }

            if (guestsList.Count > 0)
            {
                Console.Write(string.Join(", ", guestsList));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static List<string> GuestListModification(List<string> guestsList, string input)
        {
            var tokens = input.Split();

            switch (tokens[1])
            {
                case "StartsWith":
                    if (tokens[0].Equals("Remove"))
                    {
                        guestsList = guestsList.Where(x => !x.StartsWith(tokens[2])).ToList();
                        return guestsList;
                    }
                    else
                    {
                        var tempList = new List<string>();

                        for (int i = 0; i < guestsList.Count; i++)
                        {
                            if (guestsList[i].StartsWith(tokens[2]))
                            {
                                tempList.Add(guestsList[i]);
                                tempList.Add(guestsList[i]);
                            }
                            else
                            {
                                tempList.Add(guestsList[i]);
                            }
                        }

                        guestsList.Clear();
                        guestsList.AddRange(tempList);
                        return guestsList;
                    }

                case "EndsWith":
                    if (tokens[0].Equals("Remove"))
                    {
                        guestsList = guestsList.Where(x => !x.EndsWith(tokens[2])).ToList();
                        return guestsList;
                    }
                    else
                    {
                        var tempList = new List<string>();

                        for (int i = 0; i < guestsList.Count; i++)
                        {
                            if (guestsList[i].EndsWith(tokens[2]))
                            {
                                tempList.Add(guestsList[i]);
                                tempList.Add(guestsList[i]);
                            }
                            else
                            {
                                tempList.Add(guestsList[i]);
                            }
                        }

                        guestsList.Clear();
                        guestsList.AddRange(tempList);
                        return guestsList;
                    }

                case "Length":
                    var nameLength = int.Parse(tokens[2]);

                    if (tokens[0].Equals("Remove"))
                    {
                        guestsList = guestsList.Where(x => !(x.Length == nameLength)).ToList();
                        return guestsList;
                    }
                    else
                    {
                        var tempList = new List<string>();

                        for (int i = 0; i < guestsList.Count; i++)
                        {
                            if (guestsList[i].Length == nameLength)
                            {
                                tempList.Add(guestsList[i]);
                                tempList.Add(guestsList[i]);
                            }
                            else
                            {
                                tempList.Add(guestsList[i]);
                            }
                        }

                        guestsList.Clear();
                        guestsList.AddRange(tempList);
                        return guestsList;
                    }
            }
            return guestsList;
        }
    }
}

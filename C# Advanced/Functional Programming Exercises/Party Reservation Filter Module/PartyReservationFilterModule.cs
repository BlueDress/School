using System;
using System.Collections.Generic;

namespace Party_Reservation_Filter_Module
{
    public class PartyReservationFilterModule
    {
        public static void Main()
        {
            var guests = Console.ReadLine().Split();

            var guestsStatus = new bool[guests.Length];

            for (int i = 0; i < guests.Length; i++)
            {
                guestsStatus[i] = true;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Print"))
                {
                    break;
                }
                else
                {
                    guestsStatus = PartyReservationsFilterModule(guests, guestsStatus, input);
                }
            }

            var guestList = new List<string>();

            for (int i = 0; i < guests.Length; i++)
            {
                if (guestsStatus[i])
                {
                    guestList.Add(guests[i]);
                }
            }

            Console.WriteLine(string.Join(" ", guestList));

        }

        private static bool[] PartyReservationsFilterModule(string[] guests, bool[] guestsStatus, string input)
        {
            var tokens = input.Split(';');

            switch (tokens[0])
            {
                case "Add filter":
                    guestsStatus = AddFilter(guests, guestsStatus, tokens[1], tokens[2]);
                    break;
                case "Remove filter":
                    guestsStatus = RemoveFilter(guests, guestsStatus, tokens[1], tokens[2]);
                    break;
            }
            return guestsStatus;
        }

        private static bool[] RemoveFilter(string[] guests, bool[] guestsStatus, string filterType, string filterParameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].StartsWith(filterParameter))
                        {
                            guestsStatus[i] = true;
                        }
                    }
                    break;
                case "Ends with":
                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].EndsWith(filterParameter))
                        {
                            guestsStatus[i] = true;
                        }
                    }
                    break;
                case "Length":
                    var nameLength = int.Parse(filterParameter);

                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].Length == nameLength)
                        {
                            guestsStatus[i] = true;
                        }
                    }
                    break;
                case "Contains":
                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].Contains(filterParameter))
                        {
                            guestsStatus[i] = true;
                        }
                    }
                    break;
            }
            return guestsStatus;
        }

        private static bool[] AddFilter(string[] guests, bool[] guestsStatus, string filterType, string filterParameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].StartsWith(filterParameter))
                        {
                            guestsStatus[i] = false;
                        }
                    }
                    break;
                case "Ends with":
                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].EndsWith(filterParameter))
                        {
                            guestsStatus[i] = false;
                        }
                    }
                    break;
                case "Length":
                    var nameLength = int.Parse(filterParameter);

                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].Length == nameLength)
                        {
                            guestsStatus[i] = false;
                        }
                    }
                    break;
                case "Contains":
                    for (int i = 0; i < guests.Length; i++)
                    {
                        if (guests[i].Contains(filterParameter))
                        {
                            guestsStatus[i] = false;
                        }
                    }
                    break;
            }
            return guestsStatus;
        }
    }
}

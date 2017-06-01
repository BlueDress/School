using System;

namespace SoftUni_Airline
{
    public class SoftUniAirline
    {
        public static void Main()
        {
            var numberOfFlights = int.Parse(Console.ReadLine());

            var overalProfit = 0d;
            var averageProfit = 0d;

            for (int i = 0; i < numberOfFlights; i++)
            {
                var adultPassengers = int.Parse(Console.ReadLine());
                var adultTicketPrice = double.Parse(Console.ReadLine());
                var youthPassengers = int.Parse(Console.ReadLine());
                var youthTicketPrice = double.Parse(Console.ReadLine());
                var fuelPrice = double.Parse(Console.ReadLine());
                var fuelConsumption = double.Parse(Console.ReadLine());
                var flightDuration = int.Parse(Console.ReadLine());

                var income = (adultPassengers * adultTicketPrice) + (youthPassengers * youthTicketPrice);
                var expenses = fuelPrice * fuelConsumption * flightDuration;

                var profit = income - expenses;

                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We’ve got to sell more tickets! We’ve lost {profit:f3}$.");
                }
                overalProfit += profit;
            }

            averageProfit = overalProfit / numberOfFlights;

            Console.WriteLine($"Overall profit -> {overalProfit:f3}$.");
            Console.WriteLine($"Average profit -> {averageProfit:f3}$.");
        }
    }
}

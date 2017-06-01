using System;
using System.Globalization;

namespace SoftUni_Coffee_Orders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            var numberOfOrders = int.Parse(Console.ReadLine());
            var totalPrice = 0d;

            for (int i = 0; i < numberOfOrders; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var inputDate = Console.ReadLine();
                var orderDate = DateTime.ParseExact(inputDate, "d/M/yyyy", CultureInfo.InvariantCulture);
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var capsulesCount = int.Parse(Console.ReadLine());

                var price = (daysInMonth * capsulesCount) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

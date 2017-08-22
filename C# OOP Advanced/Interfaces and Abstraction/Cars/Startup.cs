using System;

namespace Cars
{
    public class Startup
    {
        public static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            IElectricCar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}

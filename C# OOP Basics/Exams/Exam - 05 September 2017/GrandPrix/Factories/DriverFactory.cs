using GrandPrix.Models.Cars;
using GrandPrix.Models.Drivers;

namespace GrandPrix.Factories
{
    public class DriverFactory
    {
        public static Driver GetDriver(string type, string name, Car car)
        {
            if (type.Equals("Aggressive"))
            {
                return new AggressiveDriver(name, car);
            }
            else if (type.Equals("Endurance"))
            {
                return new EnduranceDriver(name, car);
            }
            else
            {
                return null;
            }
        }
    }
}

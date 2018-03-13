using GrandPrix.Models.Tyres;
using GrandPrix.Models.Cars;

namespace GrandPrix.Factories
{
    public class CarFactory
    {
        public static Car GetCar(int carHp, double carFuelAmount, Tyre tyre)
        {
            return new Car(carHp, carFuelAmount, tyre);
        }
    }
}

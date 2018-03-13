using GrandPrix.Models.Contracts;
using GrandPrix.Models.Tyres;
using System;

namespace GrandPrix.Models.Cars
{
    public class Car : ICar
    {
        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public int Hp
        {
            get { return this.hp; }
            private set { this.hp = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                if (value > 160)
                {
                    this.fuelAmount = 160;
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }

        public Tyre Tyre
        {
            get { return this.tyre; }
            set { this.tyre = value; }
        }
    }
}

using System;

namespace GrandPrix.Models.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        private double grip;

        public UltrasoftTyre(double hardness, double grip) : base(hardness)
        {
            this.Grip = grip;
        }

        public double Grip
        {
            get { return this.grip; }
            private set { this.grip = value; }
        }

        public override double Degradation
        {
            set
            {
                if (value < 30)
                {
                    throw new Exception();
                }

                base.Degradation = value;
            }
        }

        public override void Degrade()
        {
            this.Degradation -= this.Grip + this.Hardness;
        }
    }
}

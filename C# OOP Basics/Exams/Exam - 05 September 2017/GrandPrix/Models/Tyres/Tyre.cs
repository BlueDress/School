using System;

namespace GrandPrix.Models.Tyres
{
    public abstract class Tyre
    {
        private string name;
        private double hardness;
        private double degradation;

        protected Tyre(double hardness)
        {
            this.Hardness = hardness;
            this.Degradation = 100;
        }

        public double Hardness
        {
            get { return this.hardness; }
            protected set { this.hardness = value; }
        }

        public virtual double Degradation
        {
            get { return this.degradation; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.degradation = value;
            }
        }

        public virtual void Degrade()
        {
            this.Degradation -= this.Hardness;
        }
    }
}


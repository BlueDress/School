

namespace Cat_Lady
{
    public class Cymric : Cat
    {
        private double furLength;

        public double FurLength
        {
            get
            {
                return this.furLength;
            }
            set
            {
                this.furLength = value;
            }
        }
        public Cymric(string name, double furLength) : base(name)
        {
            this.FurLength = furLength;
        }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.FurLength:f2}";
        }
    }
}

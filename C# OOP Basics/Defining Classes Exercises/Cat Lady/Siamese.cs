

namespace Cat_Lady
{
    public class Siamese : Cat
    {
        private int earSize;

        public int EarSize
        {
            get
            {
                return this.earSize;
            }
            set
            {
                this.earSize = value;
            }
        }
        public Siamese(string name, int earSize) : base(name)
        {
            this.EarSize = earSize;
        }

        public override string ToString()
        {
            return $"Siamese {this.Name} {this.EarSize}";
        }
    }
}

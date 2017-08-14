

namespace Cat_Lady
{
    public class StreetExtraordinaire : Cat
    {
        private int decibelsOfMeows;

        public int DecibelsOfMeows
        {
            get
            {
                return this.decibelsOfMeows;
            }
            set
            {
                this.decibelsOfMeows = value;
            }
        }
        public StreetExtraordinaire(string name, int decibelsOfMeows) : base(name)
        {
            this.DecibelsOfMeows = decibelsOfMeows;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.Name} {this.DecibelsOfMeows}";
        }
    }
}

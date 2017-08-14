

namespace Wild_Farm
{
    public abstract class Food
    {
        private int quantity;

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}


namespace Cat_Lady
{
    public class Cat
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Cat(string name)
        {
            this.Name = name;
        }
    }
}


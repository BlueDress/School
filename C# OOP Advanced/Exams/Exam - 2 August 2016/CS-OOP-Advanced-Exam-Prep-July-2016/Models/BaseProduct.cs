namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models
{
    public class BaseProduct
    {
        private string name;
        private int size;
        private int id;

        public BaseProduct(string name, int size, int id)
        {
            this.name = name;
            this.Size = size;
            this.id = id;
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Id { get { return this.id; } }
    }
}
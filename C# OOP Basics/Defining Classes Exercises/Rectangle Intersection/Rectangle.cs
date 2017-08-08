

namespace Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double hieght;
        private double topLeftXAxis;
        private double topLeftYAxis;

        public string ID
        {
            get
            {
                return this.id;
            } 
            set
            {
                this.id = value;
            }
                
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }

        }
        public double Hieght
        {
            get
            {
                return this.hieght;
            }
            set
            {
                this.hieght = value;
            }

        }
        public double TopLeftXAxis
        {
            get
            {
                return this.topLeftXAxis;
            }
            set
            {
                this.topLeftXAxis = value;
            }

        }
        public double TopLeftYAxis
        {
            get
            {
                return this.topLeftYAxis;
            }
            set
            {
                this.topLeftYAxis = value;
            }

        }

        public Rectangle(string id, double width, double height, double topLeftXAxis, double topLeftYAxis)
        {
            this.id = id;
            this.width = width;
            this.hieght = height;
            this.topLeftXAxis = topLeftXAxis;
            this.topLeftYAxis = topLeftYAxis;
        }

        public bool IntersectionCheck(Rectangle rectangle)
        {
            var intersects = false;

            if (this.topLeftXAxis + this.width >= rectangle.topLeftXAxis && this.topLeftYAxis - this.hieght <= rectangle.topLeftYAxis && this.topLeftXAxis <= rectangle.topLeftXAxis && this.topLeftYAxis >= rectangle.topLeftYAxis && (this.topLeftXAxis + this.width <= rectangle.topLeftXAxis + rectangle.width || this.topLeftYAxis - this.hieght >= rectangle.topLeftYAxis - rectangle.hieght))
            {
                intersects = true;
            }

            if (rectangle.topLeftXAxis + rectangle.width >= this.topLeftXAxis && rectangle.topLeftYAxis - rectangle.hieght <= this.topLeftYAxis && this.topLeftXAxis >= rectangle.topLeftXAxis && this.topLeftYAxis <= rectangle.topLeftYAxis && (rectangle.topLeftXAxis + rectangle.width <= this.topLeftXAxis + this.width || rectangle.topLeftYAxis - rectangle.hieght >= this.topLeftYAxis - this.hieght))
            {
                intersects = true;
            }

            return intersects;
        }
    }
}

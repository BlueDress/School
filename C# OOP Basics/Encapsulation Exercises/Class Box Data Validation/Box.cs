

using System;

namespace Class_Box_Data_Validation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return this.length; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                };

                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                };

                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                };

                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            return 2 * (this.length * this.width + this.length * this.height + this.width * this.height);
        }

        public double LateralSurfaceAreaArea()
        {
            return 2 * (this.length * this.height + this.width * this.height);
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }
    }
}

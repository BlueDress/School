﻿

namespace Raw_Data
{
    public class Cargo
    {
        private int weight;
        private string type;

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
}

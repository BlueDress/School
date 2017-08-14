

using System;

namespace Animals
{
    public abstract class Animal : SoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value.Equals(string.Empty) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
}

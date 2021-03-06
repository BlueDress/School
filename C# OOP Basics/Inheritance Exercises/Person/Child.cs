﻿

using System;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {

        }

        protected override int Age
        {
            get
            {
                return base.Age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else if (value >= 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                base.Age = value;
            }
        }

    }
}

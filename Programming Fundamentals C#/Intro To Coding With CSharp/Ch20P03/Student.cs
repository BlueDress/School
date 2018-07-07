using System;

namespace Ch20P03
{
    public class Student : IComparable
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get => name; set => name = value; }
        public double Grade { get => grade; set => grade = value; }

        public int CompareTo(object student)
        {
            return grade.CompareTo(student);
        }
    }
}

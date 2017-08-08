

namespace Salary_Increase
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is a {this.salary:f2} leva";
        }

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.age < 30)
            {
                this.salary += bonus * salary / 200;
            }
            else
            {
                this.salary += bonus * salary / 100;
            }
        }
    }
}

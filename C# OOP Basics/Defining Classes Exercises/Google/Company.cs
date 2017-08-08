

namespace Google
{
    public class Company
    {
        private string name;
        private string department;
        private double salary;

        public Company(string name, string department, double salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{this.name} {this.department} {this.salary:f2}";
        }
    }
}

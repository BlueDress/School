

namespace Company_Roster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

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
        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
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
                this.age = value;
            }
        }

        public Employee(string name, double salary, string position, string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }

        public Employee(string name, double salary, string position, string department, string email)
            :this(name, salary, position, department, email, -1)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
        }

        public Employee(string name, double salary, string position, string department, int age)
            :this(name, salary, position, department, "n/a", age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = age;
        }

        public Employee(string name, double salary, string position, string department)
            :this(name, salary, position, department, "n/a", -1)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }
    }
}

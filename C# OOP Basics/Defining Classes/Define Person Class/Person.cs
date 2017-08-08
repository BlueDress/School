

using System.Collections.Generic;

namespace Define_Person_Class
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

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

        public List<BankAccount> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.Accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public double GetBalance()
        {
            var balance = 0.0;

            foreach (var account in this.accounts)
            {
                balance += account.Balance;
            }

            return balance;
        }
    }
}



using System;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || 10 < value.Length || !value.All(x => char.IsLetterOrDigit(x)))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(base.FirstName).Append("Last Name: ").AppendLine(base.LastName).Append("Faculty number: ").AppendLine(this.facultyNumber);
            return sb.ToString();
        }
    }
}

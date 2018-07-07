using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagementSystem.Models
{
    public class Teacher : Person
    {
        private ICollection<SchoolGroup> groupsTeaching;

        public Teacher(string firstName, string lastName) : base (firstName, lastName)
        {
            this.GroupsTeaching = new List<SchoolGroup>();
        }
        
        public ICollection<SchoolGroup> GroupsTeaching { get => groupsTeaching; set => groupsTeaching = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Име:{this.FirstName} {this.LastName}");
            sb.AppendLine();

            if (this.GroupsTeaching.Count == 0)
            {
                sb.AppendLine("Няма групи, на които преподава.");
            }
            else
            {
                sb.AppendLine("Преподава на групи:");

                foreach (SchoolGroup group in this.GroupsTeaching)
                {
                    if (group.Students.Count == 0)
                    {
                        sb.AppendLine($"{group.Name} - Групата е празна.");
                    }
                    else
                    {
                        sb.AppendLine($"{group.Name} с ученици:{string.Join(", ", group.Students.Select(s => $"{s.FirstName} {s.LastName}"))}");
                    }
                }
            }

            return sb.ToString();
        }
    }
}

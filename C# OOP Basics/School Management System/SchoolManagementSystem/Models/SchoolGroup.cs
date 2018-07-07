using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public class SchoolGroup
    {
        private string name;
        private ICollection<Student> students;

        public SchoolGroup(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public string Name { get => name; set => name = value; }
        public ICollection<Student> Students { get => students; set => students = value; }
    }
}

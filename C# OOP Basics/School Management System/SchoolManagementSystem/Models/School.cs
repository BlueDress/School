using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public class School
    {
        private string name;
        private ICollection<Student> students;
        private ICollection<Teacher> teachers;
        private ICollection<SchoolGroup> schoolGroups;

        public School(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            this.SchoolGroups = new List<SchoolGroup>();
        }

        public string Name { get => name; set => name = value; }
        public ICollection<Student> Students { get => students; set => students = value; }
        public ICollection<Teacher> Teachers { get => teachers; set => teachers = value; }
        public ICollection<SchoolGroup> SchoolGroups { get => schoolGroups; set => schoolGroups = value; }
    }
}

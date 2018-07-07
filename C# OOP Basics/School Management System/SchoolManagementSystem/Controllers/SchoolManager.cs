using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Models;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class SchoolManager : IManager
    {
        private School school;

        public SchoolManager()
        {
        }

        public void CreateSchool(string schoolName)
        {
            School newSchool = new School(schoolName);
            this.school = newSchool;
        }

        public void CreateStudent(string studentFirstName, string studentLastName)
        {
            Student student = new Student(studentFirstName, studentLastName);

            this.school.Students.Add(student);
        }

        public void CreateTeacher(string teacherFirstName, string teacherLastName)
        {
            Teacher teacher = new Teacher(teacherFirstName, teacherLastName);

            this.school.Teachers.Add(teacher);
        }

        public void CreateSchoolGroup(string schoolGroupName)
        {
            SchoolGroup schoolGroup = new SchoolGroup(schoolGroupName);

            this.school.SchoolGroups.Add(schoolGroup);
        }

        public Teacher GetTeacher(string teacherFirstName, string teacherLastName)
        {
            return this.school.Teachers.FirstOrDefault(t => t.FirstName.Equals(teacherFirstName) && t.LastName.Equals(teacherLastName));
        }

        public Student GetStudent(string studentFirstName, string studentLastName)
        {
            return this.school.Students.FirstOrDefault(s => s.FirstName.Equals(studentFirstName) && s.LastName.Equals(studentLastName));
        }

        public SchoolGroup GetSchoolGroup(string schoolGroupName)
        {
            return this.school.SchoolGroups.FirstOrDefault(sg => sg.Name.Equals(schoolGroupName));
        }

        public void AddStudentToSchoolGroup(SchoolGroup schoolGroup, Student student)
        {
            schoolGroup.Students.Add(student);
        }

        public void AddSchoolGroupToTeacher(SchoolGroup schoolGroup, Teacher teacher)
        {
            teacher.GroupsTeaching.Add(schoolGroup);
        }

        public string GetTeacherInfo(string teacherFirstName, string teacherLastName)
        {
            return this.GetTeacher(teacherFirstName, teacherLastName).ToString();
        }
    }
}

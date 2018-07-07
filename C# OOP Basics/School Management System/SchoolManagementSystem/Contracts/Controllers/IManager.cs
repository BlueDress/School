using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Contracts.Controllers
{
    public interface IManager
    {
        void CreateSchool(string schoolName);
        void CreateStudent(string studentFirstName, string studentLastName);
        void CreateTeacher(string teacherFirstName, string teacherLastName);
        void CreateSchoolGroup(string schoolGroupName);

        Student GetStudent(string studentFirstName, string studentLastName);
        Teacher GetTeacher(string teacherFirstName, string teacherLastName);
        SchoolGroup GetSchoolGroup(string schoolGroupName);

        void AddStudentToSchoolGroup(SchoolGroup schoolGroup, Student student);
        void AddSchoolGroupToTeacher(SchoolGroup schoolGroup, Teacher teacher);

        string GetTeacherInfo(string teacherFirstName, string teacherLastName);
    }
}

using LearningSystem.Data.Models;

namespace LearningSystem.Services.Models.Courses
{
    public class StudentsInCourseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Grade? Grade { get; set; }
    }
}

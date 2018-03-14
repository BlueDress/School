using LearningSystem.Data.Models;
using LearningSystem.Services.Models.Courses;
using System.Linq;
using System;
using System.Collections.Generic;

namespace LearningSystem.Services.Contracts
{
    public interface ICoursesService
    {
        IQueryable<Course> GetAllCourses();

        ViewCourseModel GetCourseById(int id);

        void CreateCourse(string name, string description, DateTime startDate, DateTime endDate, string trainerId);

        IEnumerable<ListAllCoursesModel> GetAllCoursesByTrainerId(string id);

        IEnumerable<StudentsInCourseModel> GetStudentsInCourseById(int id);

        void GradeStudent(string studentId, int courseId, Grade grade);

        bool CourseExists(int id);
    }
}

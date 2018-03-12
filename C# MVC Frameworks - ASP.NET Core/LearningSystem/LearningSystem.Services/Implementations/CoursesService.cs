using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Services.Contracts;
using LearningSystem.Services.Models.Courses;
using System.Linq;
using System;
using System.Collections.Generic;

namespace LearningSystem.Services.Implementations
{
    public class CoursesService : ICoursesService
    {
        private readonly LearningSystemDbContext db;

        public CoursesService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Course> GetAllCourses()
        {
            return this.db.Courses;
        }

        public ViewCourseModel GetCourseById(int id)
        {
            return this.db.Courses.Where(c => c.Id == id).Select(c => new ViewCourseModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                TrainerName = c.Trainer.Name
            }).First();
        }

        public IEnumerable<ListAllCoursesModel> GetAllCoursesByTrainerId(string id)
        {
            return this.db.Courses.Where(c => c.TrainerId.Equals(id)).Select(c => new ListAllCoursesModel
            {
                Id = c.Id,
                Name = c.Name,
                StartDate = c.StartDate
            });
        }

        public void CreateCourse(string name, string description, DateTime startDate, DateTime endDate, string trainerId)
        {
            var course = new Course
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                TrainerId = trainerId
            };

            this.db.Courses.Add(course);
            this.db.SaveChanges();
        }

        public IEnumerable<StudentsInCourseModel> GetStudentsInCourseById(int id)
        {
            return this.db.StudentCourses.Where(sc => sc.CourseId == id).Select(sc => new StudentsInCourseModel
            {
                Name = sc.Student.Name,
                Email = sc.Student.Email
            });
        }

        public bool CourseExists(int id)
        {
            return this.db.Courses.Any(c => c.Id == id);
        }
    }
}

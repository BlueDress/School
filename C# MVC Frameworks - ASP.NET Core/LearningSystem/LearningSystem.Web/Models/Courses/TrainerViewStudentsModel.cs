using LearningSystem.Services.Models.Courses;
using System;
using System.Collections.Generic;

namespace LearningSystem.Web.Models.Courses
{
    public class TrainerViewStudentsModel
    {
        public IEnumerable<StudentsInCourseModel> Students { get; set; }

        public DateTime EndDate { get; set; }
    }
}

using System.Linq;
using System.Collections.Generic;

namespace Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade  => Grades.Average();
    }
}

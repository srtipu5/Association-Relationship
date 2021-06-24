using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public List<Course> Courses { get; set; }

        public string StudentDetails()
        {
            string studentInfo = "Student Id : " + StudentId + Environment.NewLine +
                                 "Name : " + StudentId + Environment.NewLine +
                                 "Gender : " + StudentId + Environment.NewLine;
           foreach(Course course in Courses)
            {
                studentInfo += course.CourseDetails();
            }
                return studentInfo;
        }
    }
}

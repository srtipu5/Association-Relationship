using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class Course
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public double CourseCredit { get; set; }
        public List<Student> Students { get; set; }

        public string CourseDetails()
        {
            string courseInfo = "Course Code : " + CourseCode + Environment.NewLine +
                                " Course Title : " + CourseTitle + Environment.NewLine +
                                "Course Credit : " + CourseCredit + Environment.NewLine;

            foreach (Student student in Students)
            {
                courseInfo += student.StudentDetails();
            }

            return courseInfo;
        }
    }
}

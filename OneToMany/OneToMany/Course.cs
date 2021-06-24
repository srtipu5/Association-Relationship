using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Course
    {
        public Course(string courseCode,string courseTitle,double credit)
        {
            CourseCode = courseCode;
            CourseTitle = courseTitle;
            Credit = credit;
        }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public double Credit { get; set; }
        public string GetCourseInfo()
        {
            string courseInfo = "Course Code : " + CourseCode + Environment.NewLine + "Course Title : " + CourseTitle + Environment.NewLine+ "Course Credit" + Credit+Environment.NewLine;
            return courseInfo;
        }

    }
}

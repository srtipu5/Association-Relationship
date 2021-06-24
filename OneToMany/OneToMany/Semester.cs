using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Semester
    {
        public Semester(string semesterCode, string semesterName, List<Course> courses)
        {
            SemesterCode = semesterCode;
            SemesterName = semesterName;
            Courses = courses;
        }
        public string SemesterCode { get; set; }
        public string SemesterName { get; set; }
        public List<Course> Courses { get; set; }
        public string GetSemesterInfo()
        {
            string semesterInfo = "-------Semester Details------"+Environment.NewLine+"Semester Code : "+SemesterCode+Environment.NewLine+"Semester Name : "+SemesterName+Environment.NewLine+Environment.NewLine;
            foreach(Course course in Courses)
            {
                semesterInfo += course.GetCourseInfo()+Environment.NewLine;
            }

            return semesterInfo;
        }
    }
}

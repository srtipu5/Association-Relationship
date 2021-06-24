using System;
using System.Collections.Generic;

namespace OneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();

            Console.WriteLine("How many course do u want to create ?");
            int totalCourseNo = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < totalCourseNo;i++)
            {
                Console.Write("Enter Course Code : ");
                string courseCode = Console.ReadLine();
                Console.Write("Enter Course Title : ");
                string courseTitle = Console.ReadLine();
                Console.Write("Enter Course Credit : ");
                double credit = Convert.ToDouble(Console.ReadLine());
                Course course = new Course(courseCode,courseTitle,credit);
                courses.Add(course);
  
            }
            Console.Write("Enter Semester code : ");
            string semesterCode = Console.ReadLine();
            Console.Write("Enter Semester Name : ");
            string semesterName = Console.ReadLine();
            Semester semester = new Semester(semesterCode,semesterName,courses);
            Console.Write(semester.GetSemesterInfo());
            Console.ReadKey();
        }
    }
}

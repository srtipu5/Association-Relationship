using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneRelationship
{
    class Student
    {
        public Student(string id,string name,string gender,Address address)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Address = address;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public string GetStudentInfo()
        {
            string studentInfo = "-----------Student Details -----------"+Environment.NewLine +
                "Student Id : " + Id + Environment.NewLine + "Name : " + Name + Environment.NewLine + "Gender : " + Gender
                + Environment.NewLine + "City : " + Address.City + Environment.NewLine;
           
            return studentInfo;
        }
    }
}

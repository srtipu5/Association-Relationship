using System;

namespace OneToOneRelationship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter City Name : ");
            string city = Console.ReadLine();
            Console.Write("Enter Hometown Name : ");
            string hometown = Console.ReadLine();
            Console.Write("Enter Division Name : ");
            string division = Console.ReadLine();
            Console.Write("Enter Country Name : ");
            string country = Console.ReadLine();
            Address address = new Address(city,hometown,division,country);

            Console.Write("Enter Student Id : ");
            string id = Console.ReadLine();
            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Gender : ");
            string gender = Console.ReadLine();

            Student student = new Student(id,name,gender,address);
            Console.WriteLine(student.GetStudentInfo());
            Console.ReadKey();
        }
    }
}

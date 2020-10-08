
using CMS.UI.Models;
using System;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1);
            student.FirstName = "pankajan";
            Console.WriteLine(student.FirstName);

            Course SoftwareEngineering = new Course();
            SoftwareEngineering.CourseName= "Software Engineering";

            Student pankajan = new Student(10011){
                FirstName = "Pankajan",
                LastName = "Satkunam",
                id = 10011
            };

            Console.WriteLine(pankajan.max_sports);
            Console.WriteLine(Student.School);
            Console.WriteLine(pankajan.getFullName());

            int x = 10;
            int y = 20;
            int total = 0;
            SoftwareEngineering.calculate(x,ref y,out total);
            Console.WriteLine(total);

            Staff.print();
            Staff.print("this is printed by overloading");
        
        }
    }
}

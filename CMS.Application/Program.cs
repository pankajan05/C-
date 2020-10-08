
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
            
            Staff staff = new Staff();

            Course SoftwareEngineering = new Course();

            Student pankajan = new Student(10011){
                FirstName = "Pankajan",
                LastName = "Satkunam",
                id = 10011
            };

            Console.WriteLine(pankajan.max_sports);
            Console.WriteLine(Student.School);
            Console.WriteLine(pankajan.getFullName());
        
        }
    }
}

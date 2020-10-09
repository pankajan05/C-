
using CMS.UI.Models;
using System;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //object initilizing 
            Student student = new Student(1);
            //initilize field value using object
            student.FirstName = "pankajan";
            //access object field
            Console.WriteLine(student.FirstName);

            Course SoftwareEngineering = new Course();
            SoftwareEngineering.CourseName= "Software Engineering"; //use setter
            Console.WriteLine(SoftwareEngineering.CourseName);  //use getter

            //object initilizing and add field values
            Student pankajan = new Student(10011){
                FirstName = "Pankajan",
                LastName = "Satkunam",
                id = 10011
            };

            Console.WriteLine(pankajan.max_sports);
            Console.WriteLine(Student.School);
            //call function
            Console.WriteLine(pankajan.getFullName());

            //check the reference type and the out that use to assign return value  
            int x = 10;
            int y = 20;
            int total = 0;
            SoftwareEngineering.calculate(x,ref y,out total);
            Console.WriteLine(total);

            //method overloading
            Staff.print();
            Staff.print("this is printed by overloading");

            //assign object to interface class reference type
            IStudent stu = new Student("sabinaya", "jeyakumar",12);
            IStudent.getType();
            Console.WriteLine(IStudent.No);
            Console.WriteLine(stu.sing());

            //inheritance
            Person person = new Student("tharindu", "bandara", 33);
            //type casting using explicit
            if(person is Student){
                Student s = person as Student;  //or (Student(person)) can be usable
                s.getFullName();
                Console.WriteLine(s.sing());    //access the student class after typecast
            }

            person.getFullName();
        
        }
    }
}

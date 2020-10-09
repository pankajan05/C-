using System;

namespace CMS.UI.Models
{
    //interface for the student class
    public interface IStudent
    {
        //static field for the interface that can access using interface Name
        public static int No = 10;

        //static method that can access using interface name without object creation
        public static void getType(){
            Console.WriteLine("Student");
        }

       //need to implement these methods 
        string sing();
        string getFullName();
    }
}
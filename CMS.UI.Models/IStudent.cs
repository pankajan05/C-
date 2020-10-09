using System;

namespace CMS.UI.Models
{
    public interface IStudent
    {
        public static int No = 10;
        
        public static void getType(){
            Console.WriteLine("Student");
        }

        string sing();
        string getFullName();
    }
}
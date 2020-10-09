using System;

namespace CMS.UI.Models
{
    public class Student:IStudent
    {
        public string FirstName {get; set;} = default;
        public string LastName = string.Empty;
        public int id = 10000;

        public const int max_course = 3;    //only assign a value at initilization time

        public readonly int max_sports = 2; //we can change the value in constructor only

        public static string School = "Jaffna Hindu College";

        public Student(int x) {
            id= x;
            max_sports = 5;
        }


        public string Student_Name{
            get {
                return FirstName;
            }
            set {
                FirstName = value;
            }
        }

        public string sing() {
            return "Rain, rain, go away\n Come again another day\n Daddy wants to play\n Rain, rain go away\n Rain, rain, go away\n Come again another day\n Mommy wants to play\n Rain, rain, go away";
        }

        public string getFullName(){
            return $"{FirstName} {LastName}";
        }

        ~Student(){
            Console.WriteLine("object is destroyed");
        }
    }
}

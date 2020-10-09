using System;

namespace CMS.UI.Models
{
    public class Student: Person, IStudent
    {
        

        public const int max_course = 3;    //only assign a value at initilization time

        public readonly int max_sports = 2; //we can change the value in constructor only

        public static string School = "Jaffna Hindu College";   //static field that can access using Class

        //constructor
        public Student(int x) {
            id= x;
            max_sports = 5;
        }

      //constructor that call the superclass constructor  
        public Student(string FirstName,string LastName, int id) : base(FirstName, LastName, id){
            Console.WriteLine("Student constructor called");
        }

        //getter and setter
        public string Student_Name{
            get {
                return FirstName;
            }
            set {
                FirstName = value;
            }
        }

        //implement method for the interface
        public string sing() {
            return "Rain, rain, go away\n Come again another day\n Daddy wants to play\n Rain, rain go away\n Rain, rain, go away\n Come again another day\n Mommy wants to play\n Rain, rain, go away";
        }

        
        //destructor
        ~Student(){
            Console.WriteLine("object is destroyed");
        }
    }
}

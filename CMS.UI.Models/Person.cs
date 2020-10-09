using System;
namespace CMS.UI.Models
{
    public class Person
    {
        public string FirstName {get; set;} = default;
        public string LastName = string.Empty;
        public int id = 10000;

        //default constructor
        public Person() {

        }

        //defined constructor
        public Person(string firstName, string lastName, int id){
            Console.WriteLine("Person constructor is called");
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
        }

        //method to get the fullname method to override
        public virtual string getFullName(){
            Console.WriteLine("base class method is called");
            return $"{FirstName} {LastName}";
        }
    }
}
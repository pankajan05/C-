using System;
namespace CMS.UI.Models
{
    public class Person
    {
        public string FirstName {get; set;} = default;
        public string LastName = string.Empty;
        public int id = 10000;

        public Person() {

        }

        public Person(string firstName, string lastName, int id){
            Console.WriteLine("Person constructor is called");
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
        }

        public string getFullName(){
            return $"{FirstName} {LastName}";
        }
    }
}
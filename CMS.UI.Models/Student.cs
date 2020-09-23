using System;

namespace CMS.UI.Models
{
    public class Student
    {
        private string Name = "";
        public int id;

        public Student(int x) {
            id= x;
        }

        public string Student_Name{
            get {
                return Name;
            }
            set {
                Name = value;
            }
        }

    
    }
}

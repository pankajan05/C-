using System;

namespace CMS.UI.Models
{
    public class Student
    {
        public string Name = "";
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

        public string sing() {
            return "Rain, rain, go away\n Come again another day\n Daddy wants to play\n Rain, rain go away\n Rain, rain, go away\n Come again another day\n Mommy wants to play\n Rain, rain, go away";
        }

    
    }
}

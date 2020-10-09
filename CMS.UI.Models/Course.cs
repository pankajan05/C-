namespace CMS.UI.Models
{
    public class Course
    {
        public int id {get; set;}
        private string _courseName;
        //getter and setter for the _courseName
        public string CourseName { get => _courseName !=null ? _courseName : "Null"; set => _courseName = value;}

        //calculate the total and assign to the out
        public void calculate(int x, ref int y, out int total){
            total = x + y;
        }
    }
}
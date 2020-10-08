namespace CMS.UI.Models
{
    public class Course
    {
        public int id {get; set;}
        private string _courseName;
        public string CourseName { get => _courseName !=null ? _courseName : "Null"; set => _courseName = value;}

        public void calculate(int x, ref int y, out int total){
            total = x + y;
        }
    }
}
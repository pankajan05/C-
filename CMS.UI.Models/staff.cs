using System;

namespace CMS.UI.Models
{
    public static class Staff
    {
        public static void print(){
            Console.WriteLine("This is printed using static method and static class");
        }

        public static void print(string x){
            Console.WriteLine(x);
        }
    }
}
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205242#content
namespace PropertiesUdemy
// right click on project -> open in terminal
{
    public class Person
    {
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
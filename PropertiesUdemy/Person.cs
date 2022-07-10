//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205242#content
namespace PropertiesUdemy
// right click on project -> open in terminal
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

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
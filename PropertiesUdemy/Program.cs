using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205242#content
namespace PropertiesUdemy
// right click on project -> open in terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Property is a class member that encapsulates a getter/setter
            // for accessing a field.
            // Property is used to create getter/setter wih less code.
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
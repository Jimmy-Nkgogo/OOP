using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    internal class Person
    {
        public string Name;

        public void Introduce(string otherName)
        {
            Console.WriteLine($"Hi {otherName}, I am {Name}");
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}

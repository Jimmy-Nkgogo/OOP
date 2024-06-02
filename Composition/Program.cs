using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Dog dog = new Dog();
            dog.Name = "Rex";
            Cat cat = new Cat();
            cat.Name = "Mohawk";

            dog.displayInfo();
            dog.MakeSound();
            cat.displayInfo();
            dog.MakeSound();
             */
        }
    }
    class Student
    {
        private int studentNumber;
        private string name;
        private string surname;
        public Student()
        {
            studentNumber = 0;
            name = null;
            surname = null;
        }
        public void setStudent(int num, string n, string s)
        {
            studentNumber = num;
            name = n;
            surname = s;
        }
        public void displayStudent()
        {
            Console.WriteLine("\n" + studentNumber + " " + name + " " + surname);
        }
    }
}

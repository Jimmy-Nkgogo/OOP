using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ThirdYearStudent> thirdYearStudents = new List<ThirdYearStudent>();

            
            Console.Write("Enter your student number: ");
            int studentNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your course code: ");
            string courseCode = Console.ReadLine();
            Console.Write("Enter your assignment mark: ");
            int assignmentMark = int.Parse(Console.ReadLine());
            Console.Write("Enter your test mark: ");
            int testMark = int.Parse(Console.ReadLine());

            Console.Write("Enter your student number: ");
            int studentNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname1 = Console.ReadLine();
            Console.Write("Enter your course code: ");
            string courseCode1 = Console.ReadLine();
            Console.Write("Enter your assignment mark: ");
            int assignmentMark1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your test mark: ");
            int testMark1 = int.Parse(Console.ReadLine());

            ThirdYearStudent thirdYear = new ThirdYearStudent();
            thirdYear.setStudent(studentNumber, name, surname, courseCode, assignmentMark, testMark);

            ThirdYearStudent thirdYear1 = new ThirdYearStudent();
            thirdYear1.setStudent(studentNumber1, name1, surname1, courseCode1, assignmentMark1, testMark1);

            thirdYearStudents.Add(thirdYear);
            thirdYearStudents.Add(thirdYear1);
            foreach (var student in thirdYearStudents)
            {
                student.displayStudent();
                Console.WriteLine(student.calcFinalMark());
            }
        }
    }
    abstract class Student
    {
        protected int studentNumber;
        protected string name;
        protected string surname;
        public Student()
        {
            studentNumber = 0;
            name = null;
            surname = null;
        }
        public abstract void setStudent(int num, string n, string s);

        public abstract void displayStudent();
        
    }
    class ThirdYearStudent : Student
    {
        private string courseCode;
        private int assignment;
        private int test;

        public ThirdYearStudent()
        {
            
        }
        public override void setStudent(int num, string n, string s)
        {
            studentNumber = num;
            name = n;
            surname = s;
        }
        public void setStudent(int num, string n, string s, string CourseCode,int Assignment, int Test)
        {
            studentNumber = num;
            name = n;
            surname = s;
            courseCode = CourseCode;
            assignment = Assignment;
            test = Test;
        }
        public override void displayStudent()
        {
            Console.WriteLine("\n" + studentNumber + " " + name + " " + surname + $" {courseCode} {assignment} {test}");
        }
        public double calcYearMark()
        {
            return Math.Round((assignment * 0.45) + (test * 0.55), 2);
        }
        public double calcFinalMark()
        {
            Random random = new Random();
            int examMark = random.Next(15, 86);

            double yearMark = calcYearMark();
            
            if (yearMark != 0)
                return Math.Round(examMark / yearMark, 2);
            else
            {
                return -1;
            }
        }
    }
}

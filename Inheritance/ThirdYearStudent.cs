using System;

namespace Inheritance
{
    class ThirdYearStudent : Student
    {
        private string courseCode;
        private int assignment;
        private int test;
        public ThirdYearStudent()
        {
            
        }
        public void setCourseCode(string code)
        {
            courseCode = code;
        }
        public void setAssignment(int ass)
        {
            assignment = ass;
        }
        public void setTest(int te)
        {
            test = te;
        }
        public override void displayStudent()
        {
            Console.WriteLine("\n" + studentNumber + " " + name + " " + surname + $" {courseCode} {assignment} {test}");
        }
    }
}

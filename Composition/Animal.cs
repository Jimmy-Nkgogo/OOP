using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public abstract class Animal
    {
        public string Name;
        public void setName(string name)
        {
            Name = name;
        }
        public abstract void MakeSound();
    }
    public class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Chu chu");
        }
        public void displayInfo()
        {
            Console.WriteLine();
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public void displayInfo()
        {
            Console.WriteLine();
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void displayInfo()
        {
            Console.WriteLine();
        }
    }

}

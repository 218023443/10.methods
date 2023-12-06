using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method
            SayHi();
            //method with parameters
            SayHiUser("Evans");
            //method with more parameters
            SayHiAge("John ", 55);
            Console.ReadLine();
        }
        static void SayHi() {
            Console.WriteLine("Hi");
        }
        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " +  name);
        }
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}

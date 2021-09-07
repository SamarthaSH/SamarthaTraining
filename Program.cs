using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            string age = Console.ReadLine();
            Console.WriteLine("Enter the Qualification");
            string qualification = Console.ReadLine();

            Console.WriteLine("The details given are:\nThe name entered is "+name);
            Console.WriteLine("The age is " + age);
            Console.WriteLine("The Qualification of the user is " + qualification);


        }
    }
}

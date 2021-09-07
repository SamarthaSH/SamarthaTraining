using System;

namespace SampleConApp3
{
    class DataTypeConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age which you wish to retire");
            int expectedRetireAge = int.Parse(Console.ReadLine());
            Console.WriteLine("You are going to retire after " + (expectedRetireAge - age) + "years");
            

        }
        
    }
}

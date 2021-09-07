using System;

namespace SampleConApp3
{
    class BoxingAndUnboxing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for this content");
            object value = Console.ReadLine(); // Boxing
            Console.WriteLine("The interal data type stored is " + value.GetType());
            Console.WriteLine("The upper case of this data is " + value.ToString().ToLower());

        }

    }
}

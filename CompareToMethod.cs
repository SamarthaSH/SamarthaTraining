using System;


namespace SampleConApp3
{
    class CompareToMethod
    {
        static void Main(string[] args)
        {

        
        int value1 = 234;
        int value2 = 555;
        int comparison = value1.CompareTo(value2);
                if (comparison == 0)
                {
                    Console.WriteLine("They are equal");
                }
                else if (comparison< 0)
                    Console.WriteLine("value 1 is lesser than value 2");
                else
                    Console.WriteLine("value 1 is greater than value 2");
    }
}
}

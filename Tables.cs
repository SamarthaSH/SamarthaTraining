using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp3
{
    class Tables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=1;
            while (i <= 10)
            {
                Console.WriteLine($"{num} *  {i} =  {(num * i)}");
                i++;
            }
        }
    }
}

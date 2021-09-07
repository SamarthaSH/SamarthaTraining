using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp3
{
    class Unboxing
    {
        static void Main(string[] args)
        {
            object data = 123; //Boxing
            Console.WriteLine(data.GetType());
            int temp = (int) data; // Unboxing
            temp += 10;
            data = temp;

              
        }
    }
}

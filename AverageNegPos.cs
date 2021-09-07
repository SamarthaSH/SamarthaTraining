using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp3
{
    class AverageNegPos
    {
        static void Main(string[] args)
        {
            int count1=0;
            int count2 = 0;
            int negSum=0;
            int posSum = 0;
            int posAvg = 0;
            int negAvg = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the real number");
                int realnum = int.Parse(Console.ReadLine());
                if (realnum < 0)
                {
                    count1++;
                    negSum = negSum + realnum;
                    
                }
                else if (realnum >= 0)
                {
                    count2++;
                    posSum = posSum + realnum;
                }

            }
            negAvg = negSum / count1;
            posAvg = posSum / count2;
            Console.WriteLine($"negative num Average is {negAvg}");
            Console.WriteLine($"positive num Average is {posAvg}");
        }
    }
}

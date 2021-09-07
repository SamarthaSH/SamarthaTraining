using System;


namespace SampleConApp3
{
    class PrimeNumber
    {
        public static int isPrime(int num)
        {
            int i;
            for (i = 2; i <=num - 1; i++)
            {
                if (num % i == 0)
                {
                    return 0;
                }
            }
                if(num == i)
             
                {
                    return 1;
                }
                return 0;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int num = int.Parse(Console.ReadLine());
            int result = isPrime(num);
            if (result == 0)
            {
                Console.WriteLine(num + " is not a prime");
            }
            else
            {
                Console.WriteLine(num + " is a prime");
            }
            
        }
    }
}

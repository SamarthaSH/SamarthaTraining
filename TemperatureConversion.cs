using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp3
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double celcius;
            Console.WriteLine("Enter the temperature in Celcius");
            celcius = double.Parse(Console.ReadLine());
            double kelvin = celcius + 273;
            double Fhnt = celcius * (18 / 10) + 32;
            Console.WriteLine("Temperature in Kelvin is "+ kelvin);
            Console.WriteLine("Temperature in Fnht is " + Fhnt);

        }
    }
}

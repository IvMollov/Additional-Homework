using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusFahrenheit
{
    public class CelsiusFahrenheit
    {
        public static double Celsius(double fa)
        {
            double c = ((double)fa - 32) * 5 / 9;
            return c;
        }
        public static double Fahrenheit(double c)
        {
            double fa = c * 9 / 5 + 32;
            return fa;
        }
        public static void Main()
        {
            Console.Write("Choose \"1\" for Fahrenheit to Celsius or \"2\" for Celsius to Fahrenheit: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.Write("Enter a Fahrenheit temperature: ");
                double numberA = double.Parse(Console.ReadLine());
                Console.WriteLine("Celsius equivalent of {0} Fahrenheit is {1}", numberA, Celsius(numberA));
            }
            if (a == 2)
            {
                Console.Write("Enter a Celsius temperature: ");
                double numberB = double.Parse(Console.ReadLine());
                Console.WriteLine("Fahrenheit equivalent of {0} Celsius is {1}", numberB, Fahrenheit(numberB));

            }

        }
    }

}

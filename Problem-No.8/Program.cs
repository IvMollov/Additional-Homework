using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos_x_
{
    public class Cosine
    {
        public static int Factorial(int a)
        {

            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static void Main()
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Cosine of {0} calculated with Math class is {1}", number, Math.Cos(number));
            Console.WriteLine("Cosine of {0} calculated using formula is {1}", number, Cos(number));
        }
        public static double Cos(double x)
        {
            double p = x * x;
            double q = p * p;
            return 1.0 - p / Factorial(2) + q / Factorial(4) - p * q / Factorial(6) + q * q / Factorial(8) - p * q * q / Factorial(10);
        }
    }

}

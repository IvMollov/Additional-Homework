using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDivisor
{
    class Program
    {
        public static bool CommonDivisor(int x, int y, out int least, out int greatest)
        {
            int max = x < y ? x : y;
            bool first = true;
            least = 1;
            greatest = 1;
            for(int i = 2; i <= max/2 + 1; i++)
            {
                if(((x % i) == 0) && ((y % i) == 0))
                {
                    if(first)
                    {
                        least = i;
                        first = false;
                    }
                    greatest = i;
                }
            }
            if (least != 1) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int lcd, gcd;
            int y = int.Parse(Console.ReadLine());
            if(CommonDivisor(x, y, out lcd, out gcd ))
            {
                Console.WriteLine("Least common divisor of {0} and {1} is {2}", x, y, lcd);
                Console.WriteLine("Greatest common divisor of {0} and {1} is {2}", x, y, gcd);
            }
            else
            {
                Console.WriteLine("No common divisor of {0} and {1}", x, y);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumbers
{
    public class DisplayNumbers
    {
        public static void Main()
        {
            Console.Write("Enter a digit \"a\": ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter a digit \"b\": ");
            int numberB = int.Parse(Console.ReadLine());
            Console.Write("Enter a digit \"c\": ");
            int numberC = int.Parse(Console.ReadLine());

            int resultOne = (numberA + numberB) * numberC;
            Console.WriteLine("(a+b)*c = {0}", resultOne);

            int resultTwo = numberA * numberC + numberB * numberC;
            Console.WriteLine("a*c + b*c = {0}", resultTwo);
        }
    }

}

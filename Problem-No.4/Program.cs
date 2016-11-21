using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    public class Average
    {
        public static void Main()
        {
            Console.Write("Enter first digit: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter second digit: ");
            int numberB = int.Parse(Console.ReadLine());
            Console.Write("Enter third digit: ");
            int numberC = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth digit: ");
            int numberD = int.Parse(Console.ReadLine());

            double result = (double)(numberA + numberB + numberC + numberD) / 4;
            Console.WriteLine("Average is: " + result);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    public class MultiplicationTable
    {
        public static void Main()
        {
            Console.Write("Enter a digit: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " x " + i + " = " + result);
            }
        }
    }

}

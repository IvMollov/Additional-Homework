﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumber
{
    public class DisplayNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                if (i < 4)
                {
                    Console.Write("{0} ", number);
                }
                else if (i == 4)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}", number);
                }
               
            }
            Console.WriteLine();
        }
    }

}

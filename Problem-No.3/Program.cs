using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRectangle
{
    public class DisplayRectangle
    {
        public static void Main()
        {
            Console.Write("Enter a digit: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (i > 0 && i < 4)

                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(number);
                        }

                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    else
                    {
                        Console.Write(number);
                    }
                }
                Console.WriteLine();
            }

        }
    }

}

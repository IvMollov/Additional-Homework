using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
        int count = 0;
        int[] firstDigit = { 1, 2, 3, 4, 5 };
        int[] secondDigit = { 4, 5, 6, 7, 8, 9};
        int[] thirdDigit = { 3, 4, 5, 6, 7, 8 };
        int[] fourthDigit = { 6, 7, 8, 9 };
        int[] fifthDigit = { 2, 3, 4, 5, 6, 7, 8 };
        for (int i = 0; i < fourthDigit.Length; i++)
        {
            for (int j = 0; j < fifthDigit.Length; j++)
            {
                string a = fourthDigit[i].ToString() + (fifthDigit[j]).ToString();
                if(Convert.ToInt32(a) % 4 == 0)
                {
                    count++;
                }
            }
        }
        int maxTotal = fifthDigit.Length * fourthDigit.Length * thirdDigit.Length * secondDigit.Length * firstDigit.Length;
        int maxByFour = count * thirdDigit.Length * secondDigit.Length * firstDigit.Length;       
        decimal probability = (decimal)maxByFour / (decimal)maxTotal;
        Console.WriteLine("Max numbers: {0}", maxTotal);
        Console.WriteLine("Max numbers divided by the number 4: {0}", maxByFour);
        Console.WriteLine("Probability is: {0}", probability);

        Console.ReadLine();
        
    }
    }


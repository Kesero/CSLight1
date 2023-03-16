using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumberDivider = 1;
            int maxNumberDivider = 27;
            int minNumber = 100;
            int maxNumber = 999;
            int divider = random.Next(maxNumberDivider) + minNumberDivider;
            int counter = 0;

            for (int i = 0; i <= maxNumber; i += divider)
            {
                if (minNumber <= i)
                {
                    counter++;
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Кол-во трехзначных натуральных чисел, которые кратны " + divider + ": " +
                counter);
            Console.ReadKey();
        }
    }
}
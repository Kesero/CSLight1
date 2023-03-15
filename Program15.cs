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
            int minNumber = 1;
            int maxNumber = 27;
            int minThreeDigitNumber = 100;
            int maxThreeDigitNumber = 999;
            int number = random.Next(maxNumber) + minNumber;
            int counter = 0;

            for (int i = 0; i <= maxThreeDigitNumber; i += number)
            {
                if (minThreeDigitNumber <= i)
                {
                    counter++;
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Кол-во трехзначных натуральных чисел, которые кратны " + number + ": " +
                counter);
            Console.ReadKey();
        }
    }
}
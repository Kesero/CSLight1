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
            int maxRandomValue = 101;
            int divider1 = 3;
            int divider2 = 5;
            int randomLimit = random.Next(maxRandomValue);
            Console.WriteLine("Лимит: " + randomLimit);
            int sumOfNumbers = 0;

            for (int i = 0; i <= randomLimit; i++)
            {
                if (i % divider1 == 0 || i % divider2 == 0)
                {
                    sumOfNumbers += i;
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Cумма положительных чисел, делящихся на {divider1} или {divider2}: {sumOfNumbers}");
            Console.ReadKey();
        }
    }
}
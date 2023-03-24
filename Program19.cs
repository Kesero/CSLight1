using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRows = 5;
            int countCols = 5;
            int indexOfRow2 = 1;
            int indexOfCol1 = 0;
            int summOfRow2 = 0;
            int multiplOfCol1 = 1;
            int numberIndexDifferences = 1;
            int minRandomValue = 1;
            int maxRandomValue = 10;
            int[,] numbers = new int[countRows, countCols];
            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minRandomValue, maxRandomValue);
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                summOfRow2 += numbers[indexOfRow2, i];
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiplOfCol1 *= numbers[i, indexOfCol1];
            }

            int viewForClientIndexOfRow2 = indexOfRow2 + numberIndexDifferences;
            int viewForClientIndexOfCol1 = indexOfCol1 + numberIndexDifferences;
            Console.WriteLine($"Сумма {viewForClientIndexOfRow2} строки: {summOfRow2}");
            Console.WriteLine($"Произведение {viewForClientIndexOfCol1} колонки: {multiplOfCol1}");
            Console.ReadKey();
        }
    }
}
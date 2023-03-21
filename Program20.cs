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
            int countRows = 10;
            int countCols = 10;
            int minRandomValue = 0;
            int maxRandomValue = 10;
            int numberHighest = int.MinValue;
            int numberReplacementOfLargest = 0;
            int[,] array = new int[countRows, countCols];
            Random random = new Random();

            for (int i1 = 0; i1 < array.GetLength(0); i1++)
            {
                for (int i2 = 0; i2 < array.GetLength(1); i2++)
                {
                    array[i1, i2] = random.Next(minRandomValue, maxRandomValue);
                    Console.Write(array[i1, i2] + " ");

                    if (array[i1, i2] > numberHighest)
                    {
                        numberHighest = array[i1, i2];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Максимальный элемент матрицы: " + numberHighest);

            for (int i1 = 0; i1 < array.GetLength(0); i1++)
            {
                for (int i2 = 0; i2 < array.GetLength(1); i2++)
                {
                    if (array[i1, i2] == numberHighest)
                    {
                        array[i1, i2] = numberReplacementOfLargest;
                    }

                    Console.Write(array[i1, i2] + " ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
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
            int indexOf2Row = 1;
            int indexOf1Col = 0;
            int summOf2Row = 0;
            int multiplOf1Col = 1;
            int numberIndexDifferences = 1;
            int minRandomValue = 1;
            int maxRandomValue = 10;
            int[,] array = new int[countRows, countCols];
            Random random = new Random();

            for (int i1 = 0; i1 < array.GetLength(0); i1++)
            {
                for (int i2 = 0; i2 < array.GetLength(1); i2++)
                {
                    array[i1, i2] = random.Next(minRandomValue, maxRandomValue);
                    Console.Write(array[i1, i2] + " ");

                    if (i1 == indexOf2Row)
                    {
                        summOf2Row += array[indexOf2Row, i2];
                    }
                }

                multiplOf1Col *= array[i1, indexOf1Col];
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма {indexOf2Row + numberIndexDifferences} строки: {summOf2Row}");
            Console.WriteLine($"Произведение {indexOf1Col + numberIndexDifferences} колонки: {multiplOf1Col}");
            Console.ReadKey();
        }
    }
}
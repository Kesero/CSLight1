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
            int countCols = 10;
            int minRandomValue = 0;
            int maxRandomValue = 10;
            int[] array = new int[countCols];
            int differenceToNeighboringIndex = 1;
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Локальные максимумы: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + differenceToNeighboringIndex])
                    {
                        Console.Write(array[i] + " ");
                    }
                } 
                else if (i == array.Length - differenceToNeighboringIndex)
                {
                    if (array[i - differenceToNeighboringIndex] < array[i])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else
                {
                    if (array[i - differenceToNeighboringIndex] < array[i] && array[i] > array[i + differenceToNeighboringIndex])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
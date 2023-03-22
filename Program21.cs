using System;
using System.Collections;
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
            int numberOfFirstIndex = 0;
            int differenceToNeighboringIndex = 1;
            Random random = new Random();

            for (int i = numberOfFirstIndex; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Локальные максимумы: ");


            if (array[numberOfFirstIndex] > array[numberOfFirstIndex + differenceToNeighboringIndex])
            {
                Console.Write(array[numberOfFirstIndex] + " ");
            }

            for (int i = numberOfFirstIndex + differenceToNeighboringIndex; i < array.Length - differenceToNeighboringIndex; i++)
            {
                if (array[i - differenceToNeighboringIndex] < array[i] && array[i] > array[i + differenceToNeighboringIndex])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[array.Length - differenceToNeighboringIndex - differenceToNeighboringIndex]
                < array[array.Length - differenceToNeighboringIndex])
            {
                Console.Write(array[array.Length - differenceToNeighboringIndex] + " ");
            }

            Console.ReadKey();
        }
    }
}
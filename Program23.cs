using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int maxRandomValue = 10;
            Random random = new Random();
            int[] array = new int[arrayLength];
            int countMaxRepeat = int.MinValue;
            int countRepeat = 1;
            int repeatNumber = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(maxRandomValue);
                Console.Write(array[i] + " ");

                if (i != 0 && array[i] == array[i - 1])
                {
                    countRepeat++;
                    if (countMaxRepeat < countRepeat)
                    {
                        countMaxRepeat = countRepeat;
                        repeatNumber = array[i];
                    }
                    repeatNumber = array[i];
                }
                else
                {
                    countRepeat = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Наибольшеей кол-во повторений: {countMaxRepeat}\nПовторяющееся максимальное кол-во раз число: {repeatNumber}");
            Console.ReadKey();
        }
    }
}
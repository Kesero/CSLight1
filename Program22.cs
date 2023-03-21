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
            string commandSum = "sum";
            string commandExit = "exit";
            string clientInput = "";
            int differenceToNeighboringIndex = 1;
            int[] array = new int[1];
            Console.WriteLine($"любая цифра - добавление этой цифры в сумму\n{commandSum} - посчитать сумму\n{commandExit} - выход");

            while (clientInput != commandExit)
            {
                clientInput = Console.ReadLine();

                if (clientInput == commandSum)
                {
                    int summ = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        summ += array[i];
                    }

                    Console.WriteLine("Сумма введёных чисел: " + summ);
                }
                else if (clientInput != commandExit)
                {
                    int[] arrayCopy = new int[array.Length + differenceToNeighboringIndex];

                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayCopy[i] = array[i];
                    }

                    array = arrayCopy;
                    array[array.Length - differenceToNeighboringIndex] += Convert.ToInt32(clientInput);
                } 
            }

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.InteropServices;

namespace CSHomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray(array);
            Shuffle(array);
            PrintArray(array);
            Console.ReadKey();
        }

        static void Shuffle(int[] shuffleArray)
        {
            Random random = new Random();
            int arrayLength = shuffleArray.Length;
            int randomIndex, tempValueOfArray;

            for (int i = 0; i < arrayLength; i++)
            {
                randomIndex = random.Next(arrayLength);
                tempValueOfArray = shuffleArray[i];
                shuffleArray[i] = shuffleArray[randomIndex];
                shuffleArray[randomIndex] = tempValueOfArray;
            }

        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxRandomValue = 10;
            int arrayLength = 20;
            Random random = new Random();
            int[] numbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = random.Next(maxRandomValue);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.Write("На сколько позиций вы хотите сдвинуть массив влево: ");
            int shift = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < shift; i++)
            {
                int copyFirstCell = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = copyFirstCell;
            }

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
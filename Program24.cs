using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int maxRandomValue = 10;
            Random random = new Random();
            int[] numbers = new int[arrayLength];
            Console.WriteLine("Начальный массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(maxRandomValue);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int copyToMove = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = copyToMove;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Конечный массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCols = 10;
            int minRandomValue = 0;
            int maxRandomValue = 10;
            int[] numbers = new int[countCols];
            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                numbers[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Локальные максимумы: ");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers [numbers.Length - 2] < numbers[numbers.Length - 1])
            {
                Console.Write(numbers[numbers.Length - 1] + " ");
            }

            Console.ReadKey();
        }
    }
}
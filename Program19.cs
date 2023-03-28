using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRows = 5;
            int countColumns = 5;
            int indexOfRow2 = 1;
            int indexOfColumn1 = 0;
            int summOfRow2 = 0;
            int multiplOfColumn1 = 1;
            int numberIndexDifferences = 1;
            int minRandomValue = 1;
            int maxRandomValue = 10;
            int[,] numbers = new int[countRows, countColumns];
            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minRandomValue, maxRandomValue);
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                summOfRow2 += numbers[indexOfRow2, i];
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiplOfColumn1 *= numbers[i, indexOfColumn1];
            }

            int viewForClientIndexOfRow2 = indexOfRow2 + numberIndexDifferences;
            int viewForClientIndexOfCol1 = indexOfColumn1 + numberIndexDifferences;
            Console.WriteLine($"Сумма {viewForClientIndexOfRow2} строки: {summOfRow2}");
            Console.WriteLine($"Произведение {viewForClientIndexOfCol1} колонки: {multiplOfColumn1}");
            Console.ReadKey();
        }
    }
}
using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arrayLength = 30;
            int maxRandomValue = 10;
            int countMaxRepeat = 1;
            int countRepeat = 1;
            int maxRepeatingNumber = 0;
            int[] numbers = new int[arrayLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(maxRandomValue);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != 0 && numbers[i] == numbers[i - 1])
                {
                    countRepeat++;

                    if (countMaxRepeat < countRepeat)
                    {
                        countMaxRepeat = countRepeat;
                        maxRepeatingNumber = numbers[i];
                    }
                }
                else
                {
                    countRepeat = 1;
                }
            }

            Console.WriteLine();
            Console.Write($"Наибольшеей кол-во повторений: {countMaxRepeat}\nПовторяющееся максимальное кол-во раз число: {maxRepeatingNumber}");
            Console.ReadKey();
        }
    }
}
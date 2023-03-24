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
            int countMaxRepeat = int.MinValue;
            int countRepeat = 1;
            int repeatNumber = 0;

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
                        repeatNumber = numbers[i];
                    }

                    repeatNumber = numbers[i];
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
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
            int countMaxRepeat = 1;
            int countRepeat = 1;

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
                    }
                }
                else
                {
                    countRepeat = 1;
                }
            }

            Console.WriteLine();
            Console.Write($"Наибольшеей кол-во повторений: {countMaxRepeat}\nПовторяющееся максимальное кол-во раз число: ");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                countRepeat = 1;
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        countRepeat++;
                    }
                    else if (countRepeat == countMaxRepeat)
                    {
                        Console.Write(numbers[j] + " ");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
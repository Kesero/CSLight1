using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandSum = "sum";
            string commandExit = "exit";
            string clientInput = "0";
            int[] numbers = new int[0];
            Console.WriteLine($"любая цифра - добавление этой цифры в сумму\n{commandSum} - посчитать сумму\n{commandExit} - выход");

            while (clientInput != commandExit)
            {
                if (clientInput == commandSum)
                {
                    int summ = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        summ += numbers[i];
                    }

                    Console.WriteLine("Сумма введёных чисел: " + summ);
                }
                else
                {
                    int[] arrayCopy = new int[numbers.Length + 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        arrayCopy[i] = numbers[i];
                    }

                    numbers = arrayCopy;
                    numbers[numbers.Length - 1] += Convert.ToInt32(clientInput);
                }

                clientInput = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
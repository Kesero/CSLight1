using System;
using System.Collections.Generic;
using System.Web;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string commandExit = "exit";
            string commandSumm = "summ";
            string clientInput;
            Console.WriteLine($"Введите число для добавления его в сумму или команды." +
                $"\n{commandSumm} - суммировать все введённый числа" +
                $"\n{commandExit} - выход из программы");

            do
            {
                clientInput = Console.ReadLine();

                if (clientInput == commandSumm)
                {
                    Console.WriteLine("Сумма: " + Summarize(numbers));
                }
                else if (int.TryParse(clientInput, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Недопустимый ввод.");
                }
            }
            while (clientInput != commandExit);
        }

        static int Summarize(List<int> numbers)
        {
            int summ = 0;

            foreach (int number in numbers)
            {
                summ += number;
            }

            return summ;
        }
    }
}
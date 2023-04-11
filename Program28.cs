using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientInput;

            do
            {
                Console.Write("Введите число: ");
                clientInput = Console.ReadLine();
            }
            while (!int.TryParse(clientInput, out int resaultOfParse));

            Console.WriteLine("Введённое число: " + clientInput);
        }
    }
}
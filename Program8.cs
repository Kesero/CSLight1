using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToExit = "exit";
            string clientWord = "";

            while (clientWord != wordToExit)
            {
                Console.Write("Введите специальное слово для выхода: ");
                clientWord = Console.ReadLine();
            }

            Console.WriteLine("Вы вышли из цикла!");
            Console.ReadKey();
        }
    }
}
using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordCompletion = "exit";
            string clientWord = "";
            while (clientWord != wordCompletion)
            {
                Console.Write("Введите специальное слово для выхода: ");
                clientWord = Console.ReadLine();
            }
            Console.WriteLine("Вы вышли из цикла!");
            Console.ReadKey();
        }
    }
}

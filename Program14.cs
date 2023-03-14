using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordInput;
            string password = "1234";
            int maxCountAttempts = 3;
            int numberInformationCalculationFifference = 1;

            for (int i = 0; i < maxCountAttempts; i++)
            {
                Console.Write("Введите пароль, чтобы увидеть секретное сообщение: ");
                passwordInput = Console.ReadLine();

                if (passwordInput == password)
                {
                    Console.WriteLine("*секретное сообщение*");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    int currentCountAttempts = maxCountAttempts - (i + numberInformationCalculationFifference);
                    Console.WriteLine("Неверный пароль! Осталось попыток: " + currentCountAttempts);
                }
            }
        }
    }
}
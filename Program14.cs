using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordInput;
            string password = "1234";
            int attemptСounter = 0;
            int maxCountAttempts = 3;

            while (attemptСounter < maxCountAttempts)
            {
                attemptСounter++;
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
                    int currentCountAttempts = maxCountAttempts - attemptСounter;
                    Console.WriteLine("Неверный пароль! Осталось попыток: " + currentCountAttempts);
                }
            }
        }
    }
}
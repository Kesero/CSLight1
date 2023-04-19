using System;
using System.Collections.Generic;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> shoppingsAmounts = FillShoppingsAmounts();
            int shopAccount = 0;

            while (shoppingsAmounts.Count != 0)
            {
                Console.Clear();
                Console.WriteLine("Произведена покупка на " + shoppingsAmounts.Peek() + " рублей.");
                shopAccount += shoppingsAmounts.Pop();
                Console.WriteLine("Счёт магазина:" + shopAccount);
                Console.ReadKey();
            }
        }

        static Stack<int> FillShoppingsAmounts()
        {
            Random random = new Random();
            Stack<int> shoppingsAmounts = new Stack<int>();
            int countAmounts = 5;
            int minAmount = 100;
            int maxAmount = 9999;

            for (int i = 0; i < countAmounts; i++)
            {
                shoppingsAmounts.Push(random.Next(minAmount, maxAmount));
            }

            return shoppingsAmounts;
        }
    }
}
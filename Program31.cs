using System;
using System.Collections.Generic;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationShop();
        }

        static Queue<int> FillShoppingsAmounts()
        {
            Random random = new Random();
            Queue<int> shoppingsAmounts = new Queue<int>();
            int countAmounts = 5;
            int minAmount = 100;
            int maxAmount = 9999;

            for (int i = 0; i < countAmounts; i++)
            {
                shoppingsAmounts.Enqueue(random.Next(minAmount, maxAmount));
            }

            return shoppingsAmounts;
        }

        static void OperationShop()
        {
            Queue<int> shoppingsAmounts = FillShoppingsAmounts();
            int shopAccount = 0;

            while (shoppingsAmounts.Count != 0)
            {
                Console.Clear();
                Console.WriteLine("Произведена покупка на " + shoppingsAmounts.Peek() + " рублей.");
                shopAccount += shoppingsAmounts.Dequeue();
                Console.WriteLine("Счёт магазина:" + shopAccount);
                Console.ReadKey();
            }
        }
    }
}
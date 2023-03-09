using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomLimit = rand.Next(101);
            Console.WriteLine("Лимит: " + randomLimit);
            int amount = 0;
            for (int i = 0; i <= randomLimit; i++) {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    amount += i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cумма положительных чисел, делящихся на 3 и 5: " + amount);
            Console.ReadKey();
        }
    }
}

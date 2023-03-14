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
            Random random = new Random();
            int limitRandom = 101;
            int numberDivisionCondition1 = 3;
            int numberDivisionCondition2 = 5;
            int randomLimit = random.Next(limitRandom);
            Console.WriteLine("Лимит: " + randomLimit);
            int amount = 0;

            for (int i = 0; i <= randomLimit; i++)
            {
                if ((i % numberDivisionCondition1 == 0) || (i % numberDivisionCondition2 == 0))
                {
                    amount += i;
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Cумма положительных чисел, делящихся на 3 или 5: " + amount);
            Console.ReadKey();
        }
    }
}

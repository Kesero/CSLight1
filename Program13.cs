using System;
using System.Collections.Generic;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string clientName = Console.ReadLine();
            Console.Write("Введите значёк-обрамление вашего имени: ");
            string symbolFraming = Console.ReadLine();
            int numberSideFrameIndexes = 2;
            int indexNameLine = 1;


            for (int i1 = 0; i1 < 3; i1++)
            {
                if (i1 != indexNameLine)
                {
                    for (int i2 = 0; i2 < clientName.Length + numberSideFrameIndexes; i2++)
                    {
                        Console.Write(symbolFraming);
                    }
                }
                else
                {
                    Console.Write(symbolFraming + clientName + symbolFraming);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
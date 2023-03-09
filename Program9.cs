using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int actualNumberSequence = 5;
            for (int i = actualNumberSequence; i <= 96; i += 7)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
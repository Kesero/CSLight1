using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int actualNumberSequence = 5;
            int lastNumberSequence = 96;
            int coefficientProgressionSequence = 7;

            for (int i = actualNumberSequence; i <= lastNumberSequence; i += coefficientProgressionSequence)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
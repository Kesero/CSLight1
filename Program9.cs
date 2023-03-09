using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int actualNumberSequence = 5;
            int progressionNumber = 7;
            while (actualNumberSequence < 100)
            {
                Console.Write(actualNumberSequence + " ");
                actualNumberSequence += progressionNumber;
            }
            Console.ReadKey();
        }
    }
}

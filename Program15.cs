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
            int maxNNumber = 27;
            int minThreeDigitNumber = 100;
            int maxThreeDigitNumber = 999;
            int nNumber = random.Next(maxNNumber);
            int counterThreeDigitNumbersWithDivisionN = 0;

            for (int i = minThreeDigitNumber; i <= maxThreeDigitNumber; i++)
            {
                int iCopyForCyclicDivisionCheck = i;

                while (iCopyForCyclicDivisionCheck > 0)
                {
                    iCopyForCyclicDivisionCheck -= nNumber;
                }

                if (iCopyForCyclicDivisionCheck == 0)
                {
                    counterThreeDigitNumbersWithDivisionN++;
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Кол-во трехзначных натуральных чисел, которые кратны " + nNumber + ": " +
                counterThreeDigitNumbersWithDivisionN);
            Console.ReadKey();
        }
    }
}
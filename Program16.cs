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
            int maxRandomNumber = 100000000;
            int randomNumberForComparison = random.Next(maxRandomNumber);
            int numberForComparisonInDegree = 2;
            int numberInformationCalculationDifference = 1;

            for (int i1 = 1; i1 <= int.MaxValue; i1++)
            {
                int numberComparisonsInActualDegree = numberForComparisonInDegree;

                for (int i2 = 0; i2 < i1; i2++)
                {
                    numberComparisonsInActualDegree *= numberForComparisonInDegree;
                }

                if (numberComparisonsInActualDegree > randomNumberForComparison)
                {
                    Console.WriteLine($"Минимальная степень числа {numberForComparisonInDegree}," +
                        $" превосходящее заданное число {randomNumberForComparison}: {i1 + numberInformationCalculationDifference}");
                    Console.WriteLine("Это число: " + numberComparisonsInActualDegree);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
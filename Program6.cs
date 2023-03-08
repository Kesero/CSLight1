using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeServiceMinutes = 10;
            Console.Write("Сколько человек в очереди: ");
            int countPatients = Convert.ToInt32(Console.ReadLine());
            int countMinutesPerHour = 60;
            int countTotalWaitingMinutes = countPatients * timeServiceMinutes;
            int timeWaitingHours = countTotalWaitingMinutes / countMinutesPerHour;
            int timeWaitingMinutes = countTotalWaitingMinutes % countMinutesPerHour;
            Console.WriteLine($"Вы должны отстоять в очереди {timeWaitingHours} часа и {timeWaitingMinutes} минут.");
            Console.ReadKey();
        }
    }
}

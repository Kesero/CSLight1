using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, расскажите о себе.");
            Console.Write("Как вас зовут: ");
            string clientName = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            int clientAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какое у вас образование: ");
            string clientEducation = Console.ReadLine();
            Console.Write("В каком городе вы живёте: ");
            string clientCity = Console.ReadLine();
            Console.Write("Где вы работаете: ");
            string clientWork = Console.ReadLine();
            Console.WriteLine("Информация о вас: вас зовут " +  clientName + ", вам " 
                + clientAge + " лет, ваше образование - " + clientEducation + ", вы живёте в " + clientCity + ", вы работаете в " + clientWork + ".");
            Console.ReadKey();
        }
    }
}

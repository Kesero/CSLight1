using System;

namespace CSLight1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какое сообщение вы хотите зациклить: ");
            string clientText = Console.ReadLine();
            Console.Write("Какие кол-во раз хотите повторить ваше сообщение: ");
            int countRepeats = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countRepeats; i++)
            {
                Console.WriteLine(clientText);
            }

            Console.ReadKey();
        }
    }
}
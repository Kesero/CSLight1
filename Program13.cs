using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string clientName = Console.ReadLine();
            Console.Write("Введите значёк-обрамление вашего имени: ");
            string symbolFraming = Console.ReadLine();
            string clientNameWithSideFrame = symbolFraming + clientName + symbolFraming;
            string frame = "";

            for (int i = 0; i < clientNameWithSideFrame.Length; i++)
            {
                frame += symbolFraming;
            }

            Console.WriteLine(frame + "\n" + clientNameWithSideFrame + "\n" + frame);
            Console.ReadKey();
        }
    }
}
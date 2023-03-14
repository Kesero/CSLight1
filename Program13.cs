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
            Console.Write("Введите ваше имя: ");
            string clientName = Console.ReadLine();
            Console.Write("Введите значёк-обрамление вашего имени: ");
            string symbolFraming = Console.ReadLine();
            int numberSideFrameIndexes = 2;
            string frame = "";

            for (int i1 = 0; i1 < clientName.Length + numberSideFrameIndexes; i1++)
            {
                frame += symbolFraming;
            }
            Console.WriteLine(frame + "\n" + symbolFraming + clientName + symbolFraming + "\n" + frame);

            Console.ReadKey();
        }
    }
}
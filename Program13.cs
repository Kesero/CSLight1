using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            string spacesBetweenFrameAndName = "";

            for (int i = 0; i < clientNameWithSideFrame.Length; i++)
            {
                frame += symbolFraming;
            }

            if (symbolFraming.Length > 1)
            {
                bool presenceOddInName = false;

                if (clientName.Length % 2 != 0)
                {
                    presenceOddInName = true;
                }

                int countSpacesBetweenFrameAndName = (frame.Length - clientNameWithSideFrame.Length) / 2;

                for (int i = 0; i < countSpacesBetweenFrameAndName; i++)
                {
                    spacesBetweenFrameAndName += " ";
                }

                clientNameWithSideFrame = symbolFraming + spacesBetweenFrameAndName + 
                    clientName + spacesBetweenFrameAndName;

                if (presenceOddInName)
                {
                    clientNameWithSideFrame += " ";
                }

                clientNameWithSideFrame += symbolFraming;
            }

            Console.WriteLine(frame + "\n" + clientNameWithSideFrame + "\n" + frame);
            Console.ReadKey();
        }
    }
}
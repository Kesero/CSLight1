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
            int countPictures = 52;
            int countPicturesInRow = 3;
            int countFilledRows = countPictures / countPicturesInRow;
            int countPicturesOutFilledRow = countPictures % countPicturesInRow;
            Console.WriteLine("Кол-во полность заполненных картинками рядов: " + countFilledRows);
            Console.WriteLine("Кол-во картинок сверх меры: " + countPicturesOutFilledRow);
            Console.ReadKey();
        }
    }
}

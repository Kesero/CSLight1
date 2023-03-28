using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbolSeparation = ' ';
            string text = Console.ReadLine();
            string[] textWordByWord = text.Split(symbolSeparation);
            Console.WriteLine();

            for (int i = 0; i < textWordByWord.Length; i++)
            {
                Console.WriteLine(textWordByWord[i]);
            }

            Console.ReadKey();
        }
    }
}
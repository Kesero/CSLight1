using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentageOccupancyBar = 0;
            int maxBarValue = 10;

            while (true)
            {
                int barValue = Convert.ToInt32(percentageOccupancyBar / 100.0 * maxBarValue);
                Console.Clear();
                DrawBar(0, 10, "Health", ' ', ConsoleColor.Red, maxBarValue, barValue);
                Console.SetCursorPosition(0, 0);
                Console.Write("Какой процент здоровья отобразить: ");
                percentageOccupancyBar = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void DrawBar(int x, int y, string barName, char symbol, ConsoleColor color, int maxValue, int value)
        {
            string bar = "";
            char voidSymbol = ' ';
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.SetCursorPosition(x, y);
            Console.Write(barName + " [");
            Console.BackgroundColor = color;

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += voidSymbol;
            }

            Console.Write(bar);
            Console.Write("]");
        }
    }
}
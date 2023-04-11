using System;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientInput = "";
            string commandExit = "-0";
            int maxBarValue = 10;
            double percentageRatio = 100.0;
            int percentageOccupancyBar;
            int barValue;

            while (clientInput != commandExit)
            {
                Console.Write("Какой процент здоровья отобразить: ");
                clientInput = Console.ReadLine();
                percentageOccupancyBar = Convert.ToInt32(clientInput);
                barValue = Convert.ToInt32(percentageOccupancyBar / percentageRatio * maxBarValue);
                Console.Clear();
                DrawBar(0, 10, "Health", ' ', ConsoleColor.Red, maxBarValue, barValue);
                Console.SetCursorPosition(0, 0);
            }
        }

        static void DrawBar(int xCoordinateOfConsole, int yCoordinateOfConsole, string barName, char symbol, ConsoleColor color, int maxValue, int value)
        {
            string bar = "";
            char voidSymbol = ' ';
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.SetCursorPosition(xCoordinateOfConsole, yCoordinateOfConsole);
            Console.Write(barName + " [");
            Console.BackgroundColor = color;

            if (value >= maxValue)
            {
                value = maxValue;
            }
            else if (value < 0)
            {
                value = 0;
            }

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
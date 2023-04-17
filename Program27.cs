using System;
using System.Reflection;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientInput = "";
            string commandExit = "-0";
            int maxBarLength = 10;
            double percentageRatio = 100.0;
            int percentageOccupancyBar;
            int actualBarLength;

            while (clientInput != commandExit)
            {
                Console.Write("Какой процент здоровья отобразить: ");
                clientInput = Console.ReadLine();
                percentageOccupancyBar = Convert.ToInt32(clientInput);
                actualBarLength = Convert.ToInt32(percentageOccupancyBar / percentageRatio * maxBarLength);
                Console.Clear();
                DrawBar(0, 10, "Health", ' ', ConsoleColor.Red, maxBarLength, actualBarLength);
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

            bar = CompletionBar(0, value, symbol);
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = CompletionBar(value, maxValue, voidSymbol);
            Console.Write(bar);
            Console.Write("]");
        }

        static string CompletionBar(int startingIndex, int finalIndex, char symbol)
        {
            string bar = "";

            for (int i = startingIndex; i < finalIndex; i++)
            {
                bar += symbol;
            }

            return bar;
        }
    }
}
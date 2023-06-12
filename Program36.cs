using System;
using System.Collections.Generic;
using System.Web;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(10, 10, '@');
            Renderer.PrintPlayer(player1);
            Console.ReadKey();
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Symbol { get; private set; }

        public Player (int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }
    }

    class Renderer
    {
        public static void PrintPlayer(Player player)
        {
            int xCursorPosition = 0;
            int yCursorPosition = 0;
            Console.SetCursorPosition(player.X, player.Y);
            Console.Write(player.Symbol);
            Console.SetCursorPosition(xCursorPosition, yCursorPosition);
        }
    }
}
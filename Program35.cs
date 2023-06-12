using System;
using System.Collections.Generic;
using System.Web;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(10, 10, "Marek", 0);
            player1.ShowInfo();
            Console.ReadKey();
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Name { get; private set; }
        public int Score { get; private set; }

        public Player (int x, int y, string name, int score)
        {
            X = x;
            Y = y;
            Name = name;
            Score = score;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Игрок - {Name}\nРасположение - X:{X} Y:{Y}\nСчёт - {Score}");
        }
    }
}
using System;
using System.Runtime.InteropServices;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char[,] playMap = {
            { '#','#','#','#','#','#','#','#','#','#','#','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ','#',' ','#',' ',' ','#','#','#',' ','#' },
            { '#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ','#',' ','#',' ',' ','#','#','#',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#','#','#','#','#','#','#','#','#','#','#','#' }};
            int playerX = 1;
            int playerY = 1;
            int playerDX = 0;
            int playerDY = 0;
            string playerSymbol = "@";
            bool isPlayerAlive = true;

            while (isPlayerAlive)
            {
                Console.Clear();
                PrintPlayMap(playMap);
                PrintPlayer(playerSymbol, playerX, playerY);
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        playerDX = 0;
                        playerDY = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        playerDX = 0;
                        playerDY = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerDX = -1;
                        playerDY = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        playerDX = 1;
                        playerDY = 0;
                        break;
                    default:
                        playerDX = 0;
                        playerDY = 0;
                        break;

                }

                MovePlayer(playerDX, playerDY, ref playMap, playerSymbol, ref playerX, ref playerY);
            }
        }

        public static void PrintPlayMap(char[,] playMap)
        {
            for (int i = 0; i < playMap.GetLength(0); i++)
            {
                for (int j = 0; j < playMap.GetLength(1); j++)
                {
                    Console.Write(playMap[i,j]);
                }

                Console.WriteLine();
            }
        }

        public static void PrintPlayer(string playerSymbol,int playerX, int playerY)
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(playerSymbol);
            Console.SetCursorPosition(0, 0);
        }

        public static void MovePlayer(int playerDX, int playerDY, ref char[] playMap, string playerSymbol, ref int playerX, ref int playerY)
        {
            char wallSymbol = '#';
            char voidSymbol = ' ';
            
            if (playMap[playerX + playerDX, playerY + playerDY] != wallSymbol)
            {
                playMap[playerX, playerY] = voidSymbol;
                playerX += playerDX;
                playerY += playerDY;
                playMap[playerX, playerY] = playerSymbol;
            }
        }
    }
}
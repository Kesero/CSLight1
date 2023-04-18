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
            int playerDirectionX = 0;
            int playerDirectionY = 0;
            char playerSymbol = '@';
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
                        playerDirectionX = 0;
                        playerDirectionY = -1;
                        break;

                    case ConsoleKey.DownArrow:
                        playerDirectionX = 0;
                        playerDirectionY = 1;
                        break;

                    case ConsoleKey.LeftArrow:
                        playerDirectionX = -1;
                        playerDirectionY = 0;
                        break;

                    case ConsoleKey.RightArrow:
                        playerDirectionX = 1;
                        playerDirectionY = 0;
                        break;

                    default:
                        playerDirectionX = 0;
                        playerDirectionY = 0;
                        break;

                }

                MovePlayer(playerDirectionX, playerDirectionY, ref playMap, playerSymbol, ref playerX, ref playerY);
            }
        }

        public static void PrintPlayMap(char[,] playMap)
        {
            for (int i = 0; i < playMap.GetLength(0); i++)
            {
                for (int j = 0; j < playMap.GetLength(1); j++)
                {
                    Console.Write(playMap[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void PrintPlayer(char playerSymbol, int playerX, int playerY)
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(playerSymbol);
            Console.SetCursorPosition(0, 0);
        }

        public static void MovePlayer(int positionDirectionX, int positionDirectionY, ref char[,] playMap, char playerSymbol, ref int playerX, ref int playerY)
        {
            char wallSymbol = '#';
            char voidSymbol = ' ';

            if (playMap[playerY + positionDirectionY, playerX + positionDirectionX] != wallSymbol)
            {
                playMap[playerY, playerX] = voidSymbol;
                playerX += positionDirectionX;
                playerY += positionDirectionY;
                playMap[playerY, playerX] = playerSymbol;
            }
        }
    }
}